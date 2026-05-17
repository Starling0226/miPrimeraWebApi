var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "¡Bienvenido a mi primera Web del cuatrimestre!");
app.MapGet("/Melvin-Samboy", () => "Melvin Samboy LR-2024-00567");
app.Run();