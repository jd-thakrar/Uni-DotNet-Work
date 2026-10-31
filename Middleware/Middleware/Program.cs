
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) =>
{
    Console.WriteLine("Request Started");

    await next();

    Console.WriteLine("Request Completed");
});

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello ASP.NET Core");
});

app.Run();
