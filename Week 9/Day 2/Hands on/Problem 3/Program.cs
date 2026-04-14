using ContactRateLimitApi.Data;
using Microsoft.AspNetCore.RateLimiting;
using System.Threading.RateLimiting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ContactStore>();

builder.Services.AddRateLimiter(opt =>
{
    opt.AddFixedWindowLimiter("limit", o =>
    {
        o.PermitLimit = 5;
        o.Window = TimeSpan.FromSeconds(60);
        o.QueueLimit = 0;
    });

    opt.RejectionStatusCode = 429;

    opt.OnRejected = async (ctx, token) =>
    {
        ctx.HttpContext.Response.ContentType = "text/plain";
        await ctx.HttpContext.Response.WriteAsync("Too many requests. Please try again later.", token);
    };
});

var app = builder.Build();

app.UseRateLimiter();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();