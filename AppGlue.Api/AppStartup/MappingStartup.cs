using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AppGlue.Api.AppStartup
{
    public static class MappingStartup
    {
        public static IServiceCollection AddCustomMapping(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            return services;
        }

        public static IApplicationBuilder UseCustomMapping(this IApplicationBuilder app)
        {

            return app;
        }
    }
}
