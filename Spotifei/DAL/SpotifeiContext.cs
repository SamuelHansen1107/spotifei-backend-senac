using System.Data.Common;
using Microsoft.EntityFrameworkCore;

public class SpotifeyContext : DbContext
{
    public DbSet<Musica> Musicas { get; set; } // interage com os DAO's
    public DbSet<Artista> Artistas { get; set; }
    public DbSet<Album> Albuns { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
    public DbSet<PlaylistMusica> PlaylistMusicas { get; set; }

    string stringConexao = "Server=localhost;Port=3306;Database=Spotifei;Uid=root;Pwd=S&nac2024;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao)); // configura a conexao com o banco de dados
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Musica>().HasData
        (
            new Musica()
            {
                Id = 1,
                Titulo = "Musica Exemplo",
                Duracao = new TimeSpan(0, 3, 45),
                AlbumId = 1,
                ArtistaId = 1
            }
        );

        builder.Entity<Artista>().HasData
        (
            new Artista()
            {
                Id = 1,
                Nome = "Artista Exemplo",
                Genero = "Pop"
            }
        );

        builder.Entity<Album>().HasData
        (
            new Album()
            {
                Id = 1,
                Titulo = "Album Exemplo",
                DataLancamento = new DateTime(2025, 1, 30),
                ArtistaId = 1
            }
        );
        builder.Entity<Usuario>().HasData
        (
            new Usuario()
            {
                Id = 1,
                Nome = "Usuario Exemplo",
                Email = "teste1@spotifei.com",
                Senha = "senha123",
                DataNascimento = new DateTime(2001,12,3)
            }
        );
        builder.Entity<Playlist>().HasData
        (
            new Playlist()
            {
                Id = 1,
                Nome = "Playlist Exemplo",
                IdUsuario = 1,
                DataCriacao = new DateTime(2024,6,1)
            }
        );
        builder.Entity<PlaylistMusica>().HasData
        (
            new PlaylistMusica()
            {
                Id = 1,
                IdPlaylist = 1,
                IdMusica = 1
            }
        );
    }
}