using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Puroguramu.App.Middlewares;
using Puroguramu.Domains;
using Puroguramu.Infrastructures.Data;
using Puroguramu.Infrastructures.Data.Entities;
using Puroguramu.Infrastructures.Dummies;
using Puroguramu.Infrastructures.Roslyn;

namespace Puroguramu.App;

public class BuilderConfigurator
{
    public static void Configure(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<ILogger, Logger<object>>();
        builder.Services.AddScoped<ReverseProxyLinksMiddleware>();
        builder.Services.AddScoped<IExercisesRepository, DummyExercisesRepository>();
        builder.Services.AddScoped<IAssessExercise, RoslynAssessor>();

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
            .AddDefaultIdentity<Users>()
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<PuroguramuDbContext>();

        builder.Services
            .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie();
    }
}
