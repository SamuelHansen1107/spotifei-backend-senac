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
// ========== //
musicaGroup.MapPost("/", ([FromBody] Musica musica) =>
{
    new MusicaController().AdicionarMusica(musica);
    return Results.Ok("Música adicionada com sucesso!");
});
// ========== //
musicaGroup.MapPut("/", ([FromBody] Musica musica) =>
{
    new MusicaController().AtualizarMusica(musica);
    return Results.Ok("Música atualizada com sucesso!");
});
// ========== //
musicaGroup.MapDelete("/", ([FromBody] Musica musica) =>
{
    if (musica.ArtistaId != 1)
    {
        return Results.Forbid();
    }
    else
    {
        new MusicaController().RemoverMusica(musica);
        return Results.Ok("Música removida com sucesso!");
    }
});
// ========== //
app.Run();
