using SerieAPI.Clases;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Serie handler = new Serie();

app.MapGet("/api/v1/serie", () => {
    return Results.Ok(handler.All());
});

app.MapGet("/api/v1/serie/crear", () => {
    return Results.Ok(handler.All());
});

app.Run();      


