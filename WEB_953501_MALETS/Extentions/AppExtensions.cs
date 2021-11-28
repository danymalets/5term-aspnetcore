using Microsoft.AspNetCore.Builder;
using WEB_953501_MALETS.Middleware;

namespace WEB_953501_MALETS.Extensions
{
    public static class AppExtensions
    {
        public static IApplicationBuilder UseFileLogging(this IApplicationBuilder app)
            => app.UseMiddleware<LogMiddleware>();
    }
}