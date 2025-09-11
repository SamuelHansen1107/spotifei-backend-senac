class LoginController
{
    public bool Autenticar(string email, string senha)
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        List<Usuario> usuarios = usuarioDAO.ListarTodos();

        foreach (var usuario in usuarios)
        {
            if (usuario.Email == email && usuario.Senha == senha)
            {
                return true; // Autenticação bem-sucedida
            }
        }
        return false; // Autenticação falhou
    }
}