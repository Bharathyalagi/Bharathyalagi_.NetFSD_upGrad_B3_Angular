using ContactManagement.Models;
using System.Net;
using System.Text.Json;
using WebApplication8._5.Exceptions;
using WebApplication8._5.Models;

namespace WebApplication8._5.Middleware;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionMiddleware> _logger;

    public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred");
            await HandleException(context, ex);
        }
    }

    private static Task HandleException(HttpContext context, Exception ex)
    {
        HttpStatusCode statusCode = HttpStatusCode.InternalServerError;

        if (ex is NotFoundException)
            statusCode = HttpStatusCode.NotFound;

        var response = new ErrorResponse
        {
            Message = ex.Message,
            StatusCode = (int)statusCode,
            Timestamp = DateTime.Now
        };

        var json = JsonSerializer.Serialize(response);

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)statusCode;

        return context.Response.WriteAsync(json);
    }
}