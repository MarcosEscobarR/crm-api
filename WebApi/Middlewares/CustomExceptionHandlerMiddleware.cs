using System.Net;
using WebApi.Helpers;

namespace WebApi.Middlewares;

public class CustomExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;
    // private readonly ILogger _logger;
    public CustomExceptionHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(httpContext, ex);
        }
    }
    private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        await context.Response.WriteAsync(new ErrorDetails()
        {
            StatusCode = context.Response.StatusCode,
            Message = "Internal Server Error",
            StackTrace = $"{exception.Message} - {exception.Source}"
        }.ToString());
    }
}