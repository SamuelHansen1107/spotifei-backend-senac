using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var musicaGroup = app.MapGroup("/musicas");

// ========== //

musicaGroup.MapGet("/", () =>
{
    List<Musica> musicas;
    musicas = new MusicaController().ListarTodasMusicas();
    return Results.Ok(musicas);
});

app.Run();
