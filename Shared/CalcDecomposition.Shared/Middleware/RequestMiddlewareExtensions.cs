using Microsoft.AspNetCore.Builder;

namespace CalcDecomposition.Shared.Middleware
{
    public static class RequestValidateAccessMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestValidateAccess(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ValidateAccessMiddleware>();
        }
    }
}
