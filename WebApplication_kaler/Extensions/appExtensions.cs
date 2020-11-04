using Microsoft.AspNetCore.Builder;
using WebApplication_kaler.Middleware;
namespace WebApplication_kaler.Extensions
{
    public static class AppExtensions
    {
        public static IApplicationBuilder UseFileLogging(this IApplicationBuilder app)
        => app.UseMiddleware<LogMiddleware>();
    }
}