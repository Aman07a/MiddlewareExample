var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Middleware 1
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello ");
    await next(context);
});

// Middleware 1
/*app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hello again");
});*/

// Middleware 1
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello again");
});

app.Run();