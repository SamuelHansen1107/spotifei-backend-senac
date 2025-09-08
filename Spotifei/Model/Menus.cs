// Nesse arquivo, foi colocado tudo em comentário, 
// pois as entidades/classes do Model vão somente atributos/propriedades
// antes de apagar tudo, foi só colocado em comentário para aproveitar algo


/* public class Menus
{
    public void MenuCadastro()
    {
        Console.WriteLine("Bem vindo ao SPOTFEI");
        Console.WriteLine("digite o numero para a opção desejada");
        System.Console.WriteLine("====================//====================");
        System.Console.WriteLine("1. cadastrar-se");
        System.Console.WriteLine("2. login");
        System.Console.WriteLine("====================//====================");
    }

    public void MenuSecundario()
    {
        System.Console.WriteLine("====================//====================");
        System.Console.WriteLine("1. Musicas.");
        System.Console.WriteLine("2. Artistas.");
        System.Console.WriteLine("3.Sua Playlist.");
        System.Console.WriteLine("4.encerrar programa.");
        System.Console.WriteLine("====================//====================");
        Console.WriteLine("digite a opção desejada: ");

    }

    public void MostrarMusicas(List<Musica> listaMusicas)
    {
        System.Console.WriteLine("Selecione uma música digitando o número correspondente\n");

        for (int i = 0; i < listaMusicas.Count; i++)
        {
            Musica musicaAtual = listaMusicas[i];

            System.Console.WriteLine($"Número {i + 1}:");
            System.Console.WriteLine($"Título: {musicaAtual.Titulo} //  Artista: {musicaAtual.Artista.Nome}");
            System.Console.WriteLine($"Álbum: {musicaAtual.Album.Titulo}");
            System.Console.WriteLine($"Duração: {musicaAtual.Duracao.Minutes} minutos e {musicaAtual.Duracao.Seconds} segundos\n");

            Thread.Sleep(100);
        }
    }

    public Artista MostrarArtistas(List<Artista> artistas)
    {
        while (true)
        {
            Console.WriteLine("Selecione um artista:");
            System.Console.WriteLine("====================//====================");
            for (int i = 0; i < artistas.Count; i++)
            {

                Console.WriteLine($"Número {i + 1}: {artistas[i].Nome}");

            }
            System.Console.WriteLine("====================//====================");
            Console.WriteLine("Digite o número do artista: ");
            if (int.TryParse(Console.ReadLine(), out int escolha) &&
                escolha >= 1 && escolha <= artistas.Count)
            {
                return artistas[escolha - 1];
            }

            Console.WriteLine("Opção inválida. Tente novamente.");
        }
    }

    public void CriarPlaylist(List<Musica> listaDeMusicas, List<Musica> playlist)
    {
        bool loop3 = true;

        while (loop3)
        {
            Console.Clear();
            Console.WriteLine("===============//================");
            System.Console.WriteLine("Adicionar a Playlist");
            for (int i = 0; i < listaDeMusicas.Count; i++)
            {
                Musica musicaAtual = listaDeMusicas[i];
                Console.WriteLine($"{i + 1}. {musicaAtual.Titulo} - {musicaAtual.Artista.Nome} ({musicaAtual.Duracao.Minutes}m {musicaAtual.Duracao.Seconds}s)");
            }
            Console.WriteLine("===============//================");
            Console.WriteLine("Digite o número da música para adicionar à playlist (ou 0 para sair): ");
            string entradaUsuario = Console.ReadLine()!;
            bool entradaValida = int.TryParse(entradaUsuario, out int numeroEscolhido);

            if (numeroEscolhido == 0)
            {
                loop3 = false;
                break;
            }

            Musica musicaEscolhida = listaDeMusicas[numeroEscolhido - 1];

            if (playlist.Contains(musicaEscolhida))// contains verifica se o item ja esta ou n na playlst
            {
                Console.WriteLine("Essa música já está na playlist.");
            }
            else
            {
                playlist.Add(musicaEscolhida);
                Console.WriteLine($"Música \"{musicaEscolhida.Titulo}\" adicionada à playlist!");
            }

            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Sua playlist:");

        if (playlist.Count == 0)
        {
            Console.WriteLine("Sua playlist está vazia.");
        }
        else
        {
            for (int i = 0; i < playlist.Count; i++)
            {
                Musica musica = playlist[i];
                Console.WriteLine($"{i + 1}. {musica.Titulo} - {musica.Artista.Nome} ({musica.Duracao.Minutes}m {musica.Duracao.Seconds}s)");
            }
        }

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
} */