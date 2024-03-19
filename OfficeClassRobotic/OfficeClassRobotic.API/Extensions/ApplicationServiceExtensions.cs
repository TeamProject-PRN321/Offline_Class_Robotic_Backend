using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using OfficeClassRobotic.BuisnessTier.Implement;
using OfficeClassRobotic.DAO.Accounts;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Repository.Accounts;
using OfficeClassRobotic.Repository.Attendances;
using OfficeClassRobotic.Repository.Classess;
using OfficeClassRobotic.Repository.Classrooms;
using OfficeClassRobotic.Repository.GiaoTrinhForSubject;
using OfficeClassRobotic.Repository.GiaoTrinhs;
using OfficeClassRobotic.Repository.Interfaces;
using OfficeClassRobotic.Repository.IStudentGrades;
using OfficeClassRobotic.Repository.Parents;
using OfficeClassRobotic.Repository.Students;
using OfficeClassRobotic.Repository.Teachers;
using System.Text;

namespace OfficeClassRobotic.API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            //cấu hình để kết nối với DB
            services.AddDbContext<ApplicationDBContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));
            var secretKey = configuration["JwtSettings:Key"];
            var secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);

            services.AddAuthentication(options =>
            {
                //các loại chứng thực (authentication scheme) mặc định được sử dụng. 
                //CookieAuthenticationDefaults.AuthenticationScheme để sử dụng chứng thực Cookie.
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(options =>
            {
                // Thời gian hết hạn: 20P
                options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                // Cho phép người dùng gia hạn thời gian tồn tại nếu có hoạt động từ người dùng
                options.SlidingExpiration = true;
                // Đường dẫn tới trang báo lỗi khi người dùng không có quyền truy cập.
                options.AccessDeniedPath = "/Forbidden/";
                // Cho biết cookie có quan trọng không, thông báo rằng không nên xóa nếu người dùng chọn không chấp nhận cookie.
                options.Cookie.IsEssential = true;
                // Xác định cách sử dụng cookie trên các kết nối an toàn. Trong trường hợp này,
                // nó được đặt thành CookieSecurePolicy.SameAsRequest, có nghĩa là sử dụng chính chế độ bảo mật của yêu cầu.
                options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                // Xác định giá trị SameSite của cookie, ở đây là SameSiteMode.Lax (giảm thiểu sự chia sẻ cookie).
                options.Cookie.SameSite = SameSiteMode.Lax;
            }).AddJwtBearer(opt =>
            {
                // Cho phép lưu trữ token trong AuthenticationProperties của HttpContext sau khi chứng thực thành công.
                opt.SaveToken = true;
                // Xác định xem có yêu cầu sử dụng HTTPS không. Trong trường hợp này, được đặt thành false để cho phép sử dụng HTTP.
                opt.RequireHttpsMetadata = false;
                // Các tham số để xác nhận token JWT
                opt.TokenValidationParameters = new TokenValidationParameters
                {
                    // Xác nhận rằng khóa ký của người phát hành (Issuer) là hợp lệ.
                    ValidateIssuerSigningKey = true,
                    // ValidateIssuer, ValidateAudience: Xác nhận rằng Issuer và Audience của token là hợp lệ.
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    // Xác nhận thời gian sống của Token
                    ValidateLifetime = true,
                    // ClockSkew: Điều chỉnh đồng hồ để chấp nhận token với một khoảng độ lệch thời gian nhất định.
                    ClockSkew = TimeSpan.Zero,
                    // ValidIssuer, ValidAudience: Các giá trị hợp lệ cho Issuer và Audience.
                    ValidIssuer = configuration["JwtSettings:Issuer"],
                    ValidAudience = configuration["JwtSettings:Audience"],
                    // Khóa ký để kiểm tra chữ ký của token.
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]!))
                };
            });
            services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new Microsoft.OpenApi.Models.OpenApiSecurityScheme()
                {
                    In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                    Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
                    BearerFormat = "JwtSettings",
                    Scheme = JwtBearerDefaults.AuthenticationScheme,
                    Name = "Authorization",
                    Description = "Insert JWT Token"
                });
                c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = JwtBearerDefaults.AuthenticationScheme
                            }
                        },
                        new string[]{}
                    }
                });
            });
            services.AddAuthorization(options =>
            {
                options.DefaultPolicy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();

                options.AddPolicy("Staff", policy => policy
                    .Combine(options.DefaultPolicy)
                    .RequireRole("Staff")
                    .Build());
                options.AddPolicy("Admin", policy => policy
                    .Combine(options.DefaultPolicy)
                    .RequireRole("Admin")
                    .Build());
                options.AddPolicy("Parent", policy => policy
                   .Combine(options.DefaultPolicy)
                   .RequireRole("Parent")
                   .Build());
                options.AddPolicy("Teacher", policy => policy
                   .Combine(options.DefaultPolicy)
                   .RequireRole("Teacher")
                   .Build());
                options.AddPolicy("Student", policy => policy
                   .Combine(options.DefaultPolicy)
                   .RequireRole("Student")
                   .Build());
            });
            services.AddCors();
            //add jwt
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ISubjectRepository, SubjectRepository>();
            //services.AddScoped<IParentRepostitory, ParentRepostitory>();
            services.AddScoped<IParentRepostitory, ParentRepostitory>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IGiaoTrinhRepository, GiaoTrinhRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IClassRepository, ClassRepository>();
            services.AddScoped<IAttendanceRepository, AttendanceRepository>();
            services.AddScoped<IClassroomRepository, ClassroomRepository>();
            services.AddScoped<IStudentGradeRepository, StudentGradeRepository>();

            return services;
        }
    }
}
