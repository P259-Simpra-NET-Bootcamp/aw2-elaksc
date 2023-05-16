using Entities.Models;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Repositories.Contracts;
using System.Linq.Expressions;
using LinqKit;

namespace simpraApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StaffController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<Staff> _staffValidator;

        public StaffController(IUnitOfWork unitOfWork, IValidator<Staff> staffValidator)
        {
            _unitOfWork = unitOfWork;
            _staffValidator = staffValidator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var staffList = await _unitOfWork.Staff.GetAllAsync();
            return Ok(staffList);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var staff = await _unitOfWork.Staff.GetByIdAsync(id);
            if (staff == null)
                return NotFound("Staff not found");

            return Ok(staff);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Staff staff)
        {
            var validationResult = await _staffValidator.ValidateAsync(staff);
            if (!validationResult.IsValid)
                return BadRequest(validationResult);

            await _unitOfWork.Staff.AddAsync(staff);
            await _unitOfWork.SaveAsync();

            return CreatedAtAction(nameof(GetById), new { id = staff.Id }, staff);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Staff staff)
        {
            if (id != staff.Id)
                return BadRequest();

            var validationResult = await _staffValidator.ValidateAsync(staff);
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            _unitOfWork.Staff.Update(staff);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var staff = await _unitOfWork.Staff.GetByIdAsync(id);
            if (staff == null)
                return NotFound("Staff not found");

            _unitOfWork.Staff.Remove(staff);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }

        [HttpGet("filter")]
        public async Task<IActionResult> Filter(string firstName, string city)
        {
            Expression<Func<Staff, bool>> filter = x => true; 

            if (!string.IsNullOrEmpty(firstName))
            {
                filter = filter.And(x => x.FirstName == firstName);
            }

            if (!string.IsNullOrEmpty(city))
            {
                filter = filter.And(x => x.City == city);
            }

            var filteredStaff = await _unitOfWork.Staff.GetFilteredAsync(filter);
            return Ok(filteredStaff);
        }

    }
}
