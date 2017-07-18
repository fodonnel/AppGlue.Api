using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppGlue.Api.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppGlue.Api.AppStartup
{
    public static class DbContextStartup
    {
        public static IServiceCollection AddCustomDbContext(this IServiceCollection services, IConfigurationRoot config)
        {
            services.AddDbContext<AppGlueDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            return services;
        }

        public static IApplicationBuilder UseCustomDbContext(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var provider = serviceScope.ServiceProvider;
                using (var db = provider.GetService<AppGlueDbContext>())
                {
                    db.Database.Migrate();
                }
            }

            return app;
        }
    }
}
