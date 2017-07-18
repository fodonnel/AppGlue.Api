using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AppGlue.Api.AppStartup
{
    public static class MediatrStartup
    {
        public static IServiceCollection AddCustomMediatr(this IServiceCollection services)
        {
            services.AddMediatR(typeof(Startup));
            return services;
        }

        public static IApplicationBuilder UseCustomMediatr(this IApplicationBuilder app)
        {
            return app;
        }
    }
}
