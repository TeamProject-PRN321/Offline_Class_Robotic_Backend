using Microsoft.EntityFrameworkCore;
using OfficeClassRobotic.BuisnessTier.Implement;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Repository.GiaoTrinhForSubject;
using OfficeClassRobotic.Repository.Interfaces;
using OfficeClassRobotic.Repository.Parents;
using OfficeClassRobotic.Repository.Students;

namespace OfficeClassRobotic.API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            //cấu hình để kết nối với DB
            services.AddDbContext<ApplicationDBContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddCors();
            //add jwt
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IGiaoTrinhForSubjectRepository, GiaoTrinhForSubjectRepository>();
            services.AddScoped<IParentRepostitory, ParentRepostitory>();
            services.AddScoped<IStudentRepository, StudentRepository>();


            return services;
        }
    }
}
