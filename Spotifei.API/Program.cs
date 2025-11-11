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
    new MusicaController().RemoverMusica(musica);
    return Results.Ok("Música removida com sucesso!");
});

// ========== //
// ========== //
// ========== //

var artistaGroup = app.MapGroup("/artistas");

// ========== //

artistaGroup.MapGet("/", () =>
{
    List<Artista> artistas;
    artistas = new ArtistaController().ListarTodosArtistas();
    return Results.Ok(artistas);
});
// ========== //
artistaGroup.MapPost("/", ([FromBody] Artista artista) =>
{
    new ArtistaController().AdicionarArtista(artista);
    return Results.Ok("Artista adicionado com sucesso!");
});
// ========== //
artistaGroup.MapPut("/", ([FromBody] Artista artista) =>
{
    new ArtistaController().AtualizarArtista(artista);
    return Results.Ok("Artista atualizado com sucesso!");
});
// ========== //
artistaGroup.MapDelete("/", ([FromBody] Artista artista) =>
{
    new ArtistaController().RemoverArtista(artista);
    return Results.Ok("Artista removido com sucesso!");
});

// ========== //
// ========== //
// ========== //
app.Run();
