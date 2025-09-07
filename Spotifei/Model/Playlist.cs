public class Playlist
{
    public string Nome { get; set; }
    public List<Musica> Musicas { get; set; }

    public Playlist(string nome)
    {
        Nome = nome;
        Musicas = new List<Musica>();
    }

    public Playlist()
    {
        Nome = "Minha Playlist";
        Musicas = new List<Musica>();
    }

    public void AdicionarMusica(Musica musica)
    {
        if (!Musicas.Any(m => m.Id == musica.Id))
        {
            Musicas.Add(musica);
        }
    }

    public void RemoverMusica(Musica musica)
    {
        Musicas.RemoveAll(m => m.Id == musica.Id);
    }

    public void RemoverMusicaPorIndice(int indice)
    {
        if (indice >= 0 && indice < Musicas.Count)
        {
            Musicas.RemoveAt(indice);
        }
    }

    public void LimparPlaylist()
    {
        Musicas.Clear();
    }

    public void ExibirPlaylist()
    {
        Console.WriteLine($"=== {Nome} ===");
        if (Musicas.Count == 0)
        {
            Console.WriteLine("Playlist vazia.");
        }
        else
        {
            for (int i = 0; i < Musicas.Count; i++)
            {
                var musica = Musicas[i];
                Console.WriteLine($"{i + 1}. {musica.Titulo} - {musica.Artista.Nome}");
            }
        }
    }
}

