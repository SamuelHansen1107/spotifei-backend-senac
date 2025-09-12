/* public class ServicoUsuario
    {
        private readonly Menus menu;
        private readonly Playlist playlist;

        public ServicoUsuario(Menus menu)
        {
            this.menu = menu;
            this.playlist = new Playlist("Minha Playlist");
        }

        public void MenuUsuario(List<Musica> musicas, List<Artista> artistas)
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                menu.MenuSecundario();
                int escolha = LerOpcao();
                switch (escolha)
                {
                    case 1: 
                        TocarMusica(musicas); 
                        break;
                    case 2: 
                        TocarMusicaDoArtista(musicas, artistas); 
                        break;
                    case 3: 
                        GerenciarPlaylist(musicas); 
                        break;
                    case 4: 
                        loop = false; 
                        break;
                    default: 
                        Console.WriteLine("Opcao invalida.");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }

        private void TocarMusica(List<Musica> lista)
        {
            Console.Clear();
            menu.MostrarMusicas(lista);
            int escolha = LerOpcao("Digite o numero da musica (ou 0 para voltar): ");
            if (escolha > 0 && escolha <= lista.Count)
                TocarMusicaSelecionada(lista[escolha - 1]);
        }

        private void TocarMusicaDoArtista(List<Musica> musicas, List<Artista> artistas)
        {
            var artista = menu.MostrarArtistas(artistas);
            var musicasDoArtista = musicas.Where(m => m.Artista.Nome.Equals(artista.Nome, StringComparison.OrdinalIgnoreCase)).ToList();
            
            Console.Clear();
            Console.WriteLine($"=== Musicas de {artista.Nome} ===\n");
            
            for (int i = 0; i < musicasDoArtista.Count; i++)
            {
                var musica = musicasDoArtista[i];
                Console.WriteLine($"{i + 1}: {musica.Titulo} | Album: {musica.Album.Titulo} | Duracao: {musica.Duracao.Minutes}:{musica.Duracao.Seconds:D2}");
            }
            
            int escolha = LerOpcao("\nNumero da musica (ou 0 para voltar): ");
            if (escolha > 0 && escolha <= musicasDoArtista.Count)
                TocarMusicaSelecionada(musicasDoArtista[escolha - 1]);
        }

        private void GerenciarPlaylist(List<Musica> musicas)
        {
            Console.Clear();
            playlist.ExibirPlaylist();
            
            Console.WriteLine("\n1. Adicionar musica");
            Console.WriteLine("2. Tocar musica da playlist");
            Console.WriteLine("3. Remover musica");
            Console.WriteLine("4. Limpar playlist");
            Console.WriteLine("0. Voltar");
            
            string opcao = Console.ReadLine() ?? "";
            
            switch (opcao)
            {
                case "1":
                    AdicionarNaPlaylist(musicas);
                    break;
                case "2":
                    TocarDaPlaylist();
                    break;
                case "3":
                    RemoverDaPlaylist();
                    break;
                case "4":
                    LimparPlaylist();
                    break;
            }
        }

        private void AdicionarNaPlaylist(List<Musica> musicas)
        {
            Console.Clear();
            Console.WriteLine("=== ADICIONAR NA PLAYLIST ===\n");
            
            for (int i = 0; i < musicas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {musicas[i].Titulo} - {musicas[i].Artista.Nome}");
            }
            
            int escolha = LerOpcao("\nNumero da musica para adicionar (ou 0 para cancelar): ");
            if (escolha > 0 && escolha <= musicas.Count)
            {
                playlist.AdicionarMusica(musicas[escolha - 1]);
                Console.WriteLine($"'{musicas[escolha - 1].Titulo}' adicionada na playlist!");
            }
            else if (escolha != 0)
            {
                Console.WriteLine("Opcao invalida!");
            }
            
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        private void TocarDaPlaylist()
        {
            if (playlist.Musicas.Count == 0)
            {
                Console.WriteLine("Playlist vazia!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                return;
            }

            int num = LerOpcao("Numero da musica para tocar: ");
            if (num >= 1 && num <= playlist.Musicas.Count) 
                TocarMusicaSelecionada(playlist.Musicas[num - 1]);
            else 
                Console.WriteLine("Opcao invalida.");
        }

        private void RemoverDaPlaylist()
        {
            if (playlist.Musicas.Count == 0)
            {
                Console.WriteLine("Playlist vazia!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                return;
            }

            int num = LerOpcao("Numero da musica para remover (ou 0 para cancelar): ");
            if (num >= 1 && num <= playlist.Musicas.Count)
            {
                var musicaRemovida = playlist.Musicas[num - 1];
                playlist.RemoverMusicaPorIndice(num - 1);
                Console.WriteLine($"'{musicaRemovida.Titulo}' removida da playlist!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else if (num != 0)
            {
                Console.WriteLine("Opcao invalida.");
            }
        }

        private void LimparPlaylist()
        {
            Console.Write("Tem certeza que deseja limpar toda a playlist? (s/n): ");
            string confirmacao = Console.ReadLine() ?? "";
            
            if (confirmacao.ToLower() == "s")
            {
                playlist.LimparPlaylist();
                Console.WriteLine("Playlist limpa!");
            }
            else
            {
                Console.WriteLine("Operacao cancelada.");
            }
            
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        private void TocarMusicaSelecionada(Musica musica)
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine($"   Tocando: {musica.Titulo}");
            Console.WriteLine($"   Artista: {musica.Artista.Nome}");
            Console.WriteLine($"   Album: {musica.Album.Titulo}");
            Console.WriteLine($"   Duracao: {musica.Duracao.Minutes}:{musica.Duracao.Seconds:D2}");
            Console.WriteLine("================================");
            
            // Simular reprodução
            Console.WriteLine("\nReproduzindo...");
            Thread.Sleep(2000);
            Console.WriteLine("Fim da musica.");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        private int LerOpcao(string? msg = null)
        {
            if (msg != null) Console.Write(msg);
            return int.TryParse(Console.ReadLine(), out int val) ? val : -1;
        }
    } */