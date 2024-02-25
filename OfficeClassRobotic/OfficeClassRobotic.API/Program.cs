using Microsoft.EntityFrameworkCore;
using OfficeClassRobotic.API.Extensions;
using OfficeClassRobotic.API.Middleware;
using OfficeClassRobotic.BuisnessTier.Implement;
using OfficeClassRobotic.OfficeClassRobotic.BuisnessObject.DBContext;
using OfficeClassRobotic.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//cấu hình kết nối db và cấu hình khác
builder.Services.AddApplicationServices(builder.Configuration);

//cấu hình jwt, authorize và authentication
//builder.Services.AddIdentityServices(builder.Configuration);


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseMiddleware<ExceptionMiddleware>();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API V1");
        // Thêm nút Authorize trong Swagger UI
        c.OAuthUseBasicAuthenticationWithAccessCodeGrant();
        c.OAuthAppName("Your API - Swagger UI");
        c.OAuthAdditionalQueryStringParams(new Dictionary<string, string>
                    {
                        { "access_token", "your-jwt-token" }
                    });
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
