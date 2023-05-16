using Entities.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Presentation.ActionFilters;
using Repositories.Context;
using Repositories.Contracts;
using Repositories.EfCore;
//using Repositories.Contracts;
//using Repositories.EfCore;

namespace simpraApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) //hangi ifadeyi, tipi genişletmek istiyorsak this ile vermek zorundayız. Onu yazarız ama kullanmayız başka yerde
       => services.AddDbContext<SimpDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IStaffRepository, StaffRepository>();
        }

        public static void ConfigureUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static void ConfigureValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<Staff>, StaffValidator>();
        }

    }
}
