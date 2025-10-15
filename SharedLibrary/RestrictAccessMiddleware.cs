using Microsoft.AspNetCore.Http;

namespace SharedLibrary
{
    public class RestrictAccessMiddleware(RequestDelegate next)
    {
        public async Task InvokeAsync(HttpContext context)
        {
            var referrer = context.Request.Headers["Referrer"].FirstOrDefault();

            if (!string.IsNullOrEmpty(referrer))
            {
                if (referrer != "Api-Gateway")
                {
                    context.Response.StatusCode = StatusCodes.Status403Forbidden;
                    await context.Response.WriteAsync("Invalid Request Call. Incoming call is not coming through GatewayAPI.");
                    return;
                }
                else
                {
                    await next(context);
                }
            }
            else
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                await context.Response.WriteAsync("Invalid Request Call. Incoming call is not coming through GatewayAPI.");
                return;
            }
        }
    }
}
