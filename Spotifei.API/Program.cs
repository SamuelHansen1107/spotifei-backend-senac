using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// ========== //
// ========== //
// ========== //

var musicaGroup = app.MapGroup("/musicas");

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

var usuarioGroup = app.MapGroup("/usuarios");

usuarioGroup.MapGet("/", () =>
{
    List<Usuario> usuarios;
    usuarios = new UsuarioController().ListarTodosUsuarios();
    return Results.Ok(usuarios);
});
// ========== //
usuarioGroup.MapPost("/", ([FromBody] Usuario usuario) =>
{
    new UsuarioController().AdicionarUsuario(usuario);
    return Results.Ok("Usuário adicionado com sucesso!");
});
// ========== //
usuarioGroup.MapPut("/", ([FromBody] Usuario usuario) =>
{
    new UsuarioController().AtualizarUsuario(usuario);
    return Results.Ok("Usuário atualizado com sucesso!");
});
// ========== //
usuarioGroup.MapDelete("/", ([FromBody] Usuario usuario) =>
{
    new UsuarioController().RemoverUsuario(usuario);
    return Results.Ok("Usuário removido com sucesso!");
});

// ========== //
// ========== //
// ========== //

var albumGroup = app.MapGroup("/albuns");

albumGroup.MapGet("/", () =>
{
    List<Album> albuns;
    albuns = new AlbumController().ListarTodosAlbuns();
    return Results.Ok(albuns);
});
// ========== //
albumGroup.MapPost("/", ([FromBody] Album album) =>
{
    new AlbumController().AdicionarAlbum(album);
    return Results.Ok("Álbum adicionado com sucesso!");
});
// ========== //
albumGroup.MapPut("/", ([FromBody] Album album) =>
{
    new AlbumController().AtualizarAlbum(album);
    return Results.Ok("Álbum atualizado com sucesso!");
});
// ========== //
albumGroup.MapDelete("/", ([FromBody] Album album) =>
{
    new AlbumController().RemoverAlbum(album);
    return Results.Ok("Álbum removido com sucesso!");
});

// ========== //
// ========== //
// ========== //

var playlistGroup = app.MapGroup("/playlists");

playlistGroup.MapGet("/", () =>
{
    List<Playlist> playlists;
    playlists = new PlaylistController().ListarTodasPlaylists();
    return Results.Ok(playlists);
});
// ========== //
playlistGroup.MapPost("/", ([FromBody] Playlist playlist) =>
{
    new PlaylistController().AdicionarPlaylist(playlist);
    return Results.Ok("Playlist adicionada com sucesso!");
});
// ========== //
playlistGroup.MapPut("/", ([FromBody] Playlist playlist) =>
{
    new PlaylistController().AtualizarPlaylist(playlist);
    return Results.Ok("Playlist atualizada com sucesso!");
});
// ========== //
playlistGroup.MapDelete("/", ([FromBody] Playlist playlist) =>
{
    new PlaylistController().RemoverPlaylist(playlist);
    return Results.Ok("Playlist removida com sucesso!");
});

// ========== //
// ========== //
// ========== //

var playlistMusicaGroup = app.MapGroup("/playlistmusicas");

playlistMusicaGroup.MapGet("/", () =>
{
    List<PlaylistMusica> playlistMusicas;
    playlistMusicas = new PlaylistMusicaController().ListarTodasMusicas();
    return Results.Ok(playlistMusicas);
});
// ========== //
playlistMusicaGroup.MapPost("/", ([FromBody] PlaylistMusica playlistMusica) =>
{
    new PlaylistMusicaController().AdicionarMusica(playlistMusica);
    return Results.Ok("Música adicionada na playlist com sucesso!");
});
// ========== //
playlistMusicaGroup.MapPut("/", ([FromBody] PlaylistMusica playlistMusica) =>
{
    new PlaylistMusicaController().AtualizarPlaylist(playlistMusica);
    return Results.Ok("Música removida da playlist com sucesso!");
});
// ========== //
playlistMusicaGroup.MapDelete("/", ([FromBody] PlaylistMusica playlistMusica) =>
{
    new PlaylistMusicaController().RemoverMusica(playlistMusica);
    return Results.Ok("Música removida da playlist com sucesso!");
});

// ========== //
// ========== //
// ========== //

app.Run();
