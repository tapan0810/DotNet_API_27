using DotNet_API_27.Data;
using DotNet_API_27.Helper;
using DotNet_API_27.Service;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddDbContext<ClassDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("con")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// 🔹 Services
builder.Services.AddScoped<IClassService, ClassService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IJwtHelper, JwtHelper>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();