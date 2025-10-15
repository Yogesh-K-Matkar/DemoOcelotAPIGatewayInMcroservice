using Microsoft.AspNetCore.Mvc;

namespace GatewayAPI.Middlewares
{
    public class TokenCheckerMiddleware(RequestDelegate next)
    {
        public async Task InvokeAsync(HttpContext context)
        {

            string requestPath = context.Request.Path.Value!;

            if (requestPath.Contains("AccountRegister", StringComparison.CurrentCultureIgnoreCase) ||
                requestPath.Contains("AccountLogin", StringComparison.CurrentCultureIgnoreCase) ||
                requestPath.Equals("/"))
            {
                await next(context);
            }
            else
            {
                var authHeader = context.Request.Headers.Authorization;

                if (authHeader.FirstOrDefault() == null)
                {
                    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    await context.Response.WriteAsync("Access denied.");
                }
                else 
                { 
                    await next(context); 
                }
            }
        }
    }
}
