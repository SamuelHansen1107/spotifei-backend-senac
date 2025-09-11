// public class ServicoLogin
// {
//     private readonly UsuarioDAO usuarioDAO;

//     public ServicoLogin()
//     {
//         usuarioDAO = new UsuarioDAO();
//     }

//     public (bool sucesso, bool isAdmin) MenuLogin()
//     {
//         while (true)
//         {
//             try
//             {
//                 Console.Clear();
//                 Console.WriteLine("======== SPOTIFEI ========");
//                 Console.WriteLine("1. Fazer Login");
//                 Console.WriteLine("2. Cadastrar Usuario");
//                 Console.WriteLine("3. Login Admin");
//                 Console.WriteLine("4. Gerenciar Usuarios (Admin)");
//                 Console.WriteLine("0. Sair");
//                 Console.Write("Escolha uma opcao: ");

//                 string escolha = Console.ReadLine() ?? "";

//                 switch (escolha)
//                 {
//                     case "1":
//                         if (FazerLogin()) return (true, false);
//                         break;
//                     case "2":
//                         CadastrarUsuario();
//                         break;
//                     case "3":
//                         if (LoginAdmin()) return (true, true);
//                         break;
//                     case "4":
//                         GerenciarUsuarios();
//                         break;
//                     case "0":
//                         Console.WriteLine("Obrigado por usar o Spotifei!");
//                         Environment.Exit(0);
//                         break;
//                     default:
//                         Console.WriteLine("Opcao invalida!");
//                         Thread.Sleep(1000);
//                         break;
//                 }
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine($"Erro no menu: {ex.Message}");
//                 Console.WriteLine("Pressione qualquer tecla para continuar...");
//                 Console.ReadKey();
//             }
//         }
//     }

//     private void CadastrarUsuario()
//     {
//         try
//         {
//             Console.Clear();
//             Console.WriteLine("=== CADASTRO DE USUARIO ===");

//             Console.Write("Nome: ");
//             string nome = Console.ReadLine() ?? "";

//             Console.Write("Email: ");
//             string email = Console.ReadLine() ?? "";

//             Console.Write("Senha: ");
//             string senha = Console.ReadLine() ?? "";

//             if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
//             {
//                 Console.WriteLine("Todos os campos sao obrigatorios!");
//                 Console.WriteLine("Pressione qualquer tecla para continuar...");
//                 Console.ReadKey();
//                 return;
//             }

//             Usuario novoUsuario = new Usuario(nome, email, senha, DateTime.Now);
//             usuarioDAO.AdicionarUsuario(novoUsuario);

//             Console.WriteLine("Usuario cadastrado com sucesso!");
//             Console.WriteLine("Pressione qualquer tecla para continuar...");
//             Console.ReadKey();
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Erro no cadastro: {ex.Message}");
//             Console.WriteLine("Pressione qualquer tecla para continuar...");
//             Console.ReadKey();
//         }
//     }

//     private bool FazerLogin()
//     {
//         try
//         {
//             Console.Clear();
//             Console.WriteLine("=== LOGIN ===");

//             Console.Write("Email: ");
//             string email = Console.ReadLine() ?? "";

//             Console.Write("Senha: ");
//             string senha = Console.ReadLine() ?? "";

//             Usuario? usuario = usuarioDAO.BuscarPorEmailSenha(email, senha);

//             if (usuario != null)
//             {
//                 Console.WriteLine("Login efetuado com sucesso!");
//                 Console.WriteLine("Bem-vindo ao Spotifei!");
//                 Console.WriteLine($"Ola, {usuario.Nome}!");
//                 Thread.Sleep(2000);
//                 return true;
//             }
//             else
//             {
//                 Console.WriteLine("Usuario ou senha invalidos!");
//                 Console.WriteLine("Pressione qualquer tecla para continuar...");
//                 Console.ReadKey();
//                 return false;
//             }
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Erro no login: {ex.Message}");
//             Console.WriteLine("Pressione qualquer tecla para continuar...");
//             Console.ReadKey();
//             return false;
//         }
//     }

//     private bool LoginAdmin()
//     {
//         try
//         {
//             Console.Clear();
//             Console.WriteLine("=== LOGIN ADMIN ===");

//             Console.Write("Usuario Admin: ");
//             string usuario = Console.ReadLine() ?? "";

//             Console.Write("Senha Admin: ");
//             string senha = Console.ReadLine() ?? "";

//             if (usuario == "admin" && senha == "admin123")
//             {
//                 Console.WriteLine("Login admin efetuado com sucesso!");
//                 Thread.Sleep(1000);
//                 return true;
//             }
//             else
//             {
//                 Console.WriteLine("Usuario ou senha de admin invalidos!");
//                 Console.WriteLine("Pressione qualquer tecla para continuar...");
//                 Console.ReadKey();
//                 return false;
//             }
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Erro no login admin: {ex.Message}");
//             Console.WriteLine("Pressione qualquer tecla para continuar...");
//             Console.ReadKey();
//             return false;
//         }
//     }

//     private void GerenciarUsuarios()
//     {
//         while (true)
//         {
//             try
//             {
//                 Console.Clear();
//                 Console.WriteLine("=== GERENCIAR USUARIOS ===");
//                 Console.WriteLine("1. Listar Usuarios");
//                 Console.WriteLine("2. Excluir Usuario");
//                 Console.WriteLine("0. Voltar");
//                 Console.Write("Escolha uma opcao: ");

//                 string escolha = Console.ReadLine() ?? "";

//                 switch (escolha)
//                 {
//                     case "1":
//                         ListarUsuarios();
//                         break;
//                     case "2":
//                         ExcluirUsuario();
//                         break;
//                     case "0":
//                         return;
//                     default:
//                         Console.WriteLine("Opcao invalida!");
//                         Thread.Sleep(1000);
//                         break;
//                 }
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine($"Erro no gerenciamento: {ex.Message}");
//                 Console.WriteLine("Pressione qualquer tecla para continuar...");
//                 Console.ReadKey();
//             }
//         }
//     }

//     private void ListarUsuarios()
//     {
//         try
//         {
//             Console.Clear();
//             Console.WriteLine("=== USUARIOS CADASTRADOS ===\n");

//             List<Usuario> usuarios = usuarioDAO.ListarTodosUsuarios();

//             if (usuarios.Count == 0)
//             {
//                 Console.WriteLine("Nenhum usuario cadastrado.");
//             }
//             else
//             {
//                 foreach (var usuario in usuarios)
//                 {
//                     Console.WriteLine($"ID: {usuario.Id} | Nome: {usuario.Nome} | Email: {usuario.Email}");
//                 }
//             }

//             Console.WriteLine("\nPressione qualquer tecla para continuar...");
//             Console.ReadKey();
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Erro ao listar usuarios: {ex.Message}");
//             Console.WriteLine("Pressione qualquer tecla para continuar...");
//             Console.ReadKey();
//         }
//     }

//     private void ExcluirUsuario()
//     {
//         try
//         {
//             Console.Clear();
//             Console.WriteLine("=== EXCLUIR USUARIO ===\n");

//             List<Usuario> usuarios = usuarioDAO.ListarTodosUsuarios();

//             if (usuarios.Count == 0)
//             {
//                 Console.WriteLine("Nenhum usuario para excluir.");
//                 Console.WriteLine("Pressione qualquer tecla para continuar...");
//                 Console.ReadKey();
//                 return;
//             }

//             foreach (var usuario in usuarios)
//             {
//                 Console.WriteLine($"ID: {usuario.Id} | Nome: {usuario.Nome} | Email: {usuario.Email}");
//             }

//             Console.Write("\nDigite o ID do usuario para excluir (ou 0 para cancelar): ");
//             if (int.TryParse(Console.ReadLine(), out int id))
//             {
//                 if (id == 0) return;

//                 Usuario? usuarioParaExcluir = usuarios.FirstOrDefault(u => u.Id == id);
//                 if (usuarioParaExcluir != null)
//                 {
//                     Console.Write($"Tem certeza que deseja excluir '{usuarioParaExcluir.Nome}'? (s/n): ");
//                     string confirmacao = Console.ReadLine() ?? "";

//                     if (confirmacao.ToLower() == "s")
//                     {
//                         usuarioDAO.ExcluirUsuario(usuarioParaExcluir);
//                         Console.WriteLine("Usuario excluido com sucesso!");
//                     }
//                     else
//                     {
//                         Console.WriteLine("Operacao cancelada.");
//                     }
//                 }
//                 else
//                 {
//                     Console.WriteLine("Usuario nao encontrado!");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("ID invalido!");
//             }

//             Console.WriteLine("Pressione qualquer tecla para continuar...");
//             Console.ReadKey();
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Erro ao excluir usuario: {ex.Message}");
//             Console.WriteLine("Pressione qualquer tecla para continuar...");
//             Console.ReadKey();
//         }
//     }
// }