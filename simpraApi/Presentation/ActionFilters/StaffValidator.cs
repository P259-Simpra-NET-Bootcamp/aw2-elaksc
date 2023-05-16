using Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.ActionFilters
{
    public class StaffValidator : AbstractValidator<Staff>
    {
        public StaffValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty().WithMessage("First name is required.");
            RuleFor(s => s.LastName).NotEmpty().WithMessage("Last name is required.");
            RuleFor(s => s.Email).NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Email is not valid.");
            RuleFor(s => s.Phone).NotEmpty().WithMessage("Phone number is required.");
            RuleFor(s => s.DateOfBirth).NotEmpty().WithMessage("Date of birth is required.");
            RuleFor(s => s.AddressLine1).NotEmpty().WithMessage("Address is required.");
            RuleFor(s => s.City).NotEmpty().WithMessage("City is required.");
            RuleFor(s => s.Country).NotEmpty().WithMessage("Country is required.");
            RuleFor(s => s.Province).NotEmpty().WithMessage("Province is required.");
        }
    }
}
