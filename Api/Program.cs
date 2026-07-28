var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapControllers();

// ─── Endpoints ───────────────────────────────────────────────

app.MapGet("/", () => new { mensaje = "Bienvenido a Apuntao API" });

app.MapGet("/items", () =>
{
    var items = new[]
    {
        new { Id = 1, Nombre = "Tarea de prueba 1" },
        new { Id = 2, Nombre = "Tarea de prueba 2" },
        new { Id = 3, Nombre = "Tarea de prueba 3" },
    };
    return items;
});

app.MapPost("/items", async (HttpContext http) =>
{
    var body = await new StreamReader(http.Request.Body).ReadToEndAsync();
    return Results.Ok(new { recibido = body });
});

app.Run();
