public class Playlist
{
    public string Nome { get; set; }
    public List<Musica> Musicas { get; set; }

    public Playlist(string nome)
    {
        Nome = nome;
        Musicas = new List<Musica>();
    }
}

