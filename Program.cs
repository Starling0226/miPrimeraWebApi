var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "¡Bienvenido a mi primera Web del cuatrimestre!");
app.MapGet("/Melvin-Samboy", () => {

var informacion = new Dictionary<string, string>
    {
        { "Nombre", "Melvin Starlin" },
        { "Apellido", "Samboy" },
        { "Matricula", "LR-2024-00567" }
    };

    return Results.Ok(informacion);

});
app.Run();