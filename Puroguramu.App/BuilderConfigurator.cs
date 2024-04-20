using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Puroguramu.App.Middlewares;
using Puroguramu.Domains;
using Puroguramu.Domains.Models;
using Puroguramu.Domains.Repositories;
using Puroguramu.Infrastructures.Data;
using Puroguramu.Infrastructures.Data.Entities;
using Puroguramu.Infrastructures.Data.Repositories;
using Puroguramu.Infrastructures.Roslyn;

namespace Puroguramu.App;

public static class BuilderConfigurator
{
    public static void Configure(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<ILogger, Logger<object>>();
        builder.Services.AddScoped<ReverseProxyLinksMiddleware>();
        builder.Services.AddScoped<IAssessExercise, RoslynAssessor>();
        builder.Services.AddScoped<IPasswordHasher<AppUser>, PasswordHasher<AppUser>>();

        builder.Services.AddScoped<IExerciseRepository, ExerciseRepository>();
        builder.Services.AddScoped<ILessonRepository, LessonsRepository>();
        builder.Services.AddScoped<IUserRepository, UserRepository>();

        builder.Services.AddRazorPages();

        if (builder.Environment.IsDevelopment())
        {
            builder.Services.AddDbContext<PuroguramuDbContext>(options =>
            {
                options.UseSqlite(builder.Configuration.GetConnectionString("DbContext"));
            });
        }
        else if (builder.Environment.IsProduction())
        {
            builder.Services.AddDbContext<PuroguramuDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DbContext"));
            });
        }

        builder.Services
            .AddDefaultIdentity<Users>(options =>
            {
                options.User.RequireUniqueEmail = true;
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<PuroguramuDbContext>();

        builder.Services
            .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie();
    }
}
