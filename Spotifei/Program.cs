
using System;
using Spotifei.View;



namespace Spotifei
{
	class Program
	{
		static void Main(string[] args)
		{
			Menus menus = new Menus();
			LoginView loginView = new LoginView();
			ServicoUsuario usuarioView = new ServicoUsuario(menus);
			var musicas = new System.Collections.Generic.List<Musica>();
			var artistas = new System.Collections.Generic.List<Artista>();
			bool sair = false;
			while (!sair)
			{
				Console.Clear();
				menus.MenuCadastro();
				string escolha = Console.ReadLine() ?? "";
				switch (escolha)
				{
					case "1":
						loginView.CadastrarUsuario();
						break;
					case "2":
						if (loginView.FazerLogin())
						{
							usuarioView.MenuUsuario(musicas, artistas);
						}
						break;
					case "3":
				sair = true;
				break;
			default:
				Console.WriteLine("Opção inválida!");
				Console.ReadKey();
				break;
			}
		}
	}
}
}

