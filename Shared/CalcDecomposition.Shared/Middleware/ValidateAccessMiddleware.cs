using CalcLocaliza.Shared.Cryptography;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace CalcLocaliza.Shared.Middleware
{
    public class ValidateAccessMiddleware
    {
        private readonly RequestDelegate _next;

        public ValidateAccessMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            const string headerKey = "Decomposition-Calculation";
            var headerValue = GetHeaderValue();

            if (httpContext.Request.Headers.ContainsKey(headerKey) &&
                httpContext.Request.Headers[headerKey].ToString() == headerValue)
            {
                await _next(httpContext);
            }
            else
            {
                httpContext.Response.StatusCode = StatusCodes.Status403Forbidden;
                await httpContext.Response.WriteAsync("Acesso não permitido.");
            }
        }

        private string GetHeaderValue()
        {
            var value = $"security-key-{DateTime.Now.Day}";
            return Md5Hash.CreateMD5(value);
        }
    }
}
