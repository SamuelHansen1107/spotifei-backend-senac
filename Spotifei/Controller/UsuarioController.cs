class UsuarioController
{
    public bool VerificarSeExisteUsuario(int id)
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        var usuario = usuarioDAO.Listar(id);
        return usuario != null; // vai verificar se existe o usuario, caso exista ele retorna o usuario
    }
    public void AdicionarUsuario(Usuario usuario)
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        usuarioDAO.Cadastrar(usuario);
    }
    public void RemoverUsuario(int id)
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        usuarioDAO.Excluir(id);
    }
    public void AtualizarUsuario(Usuario usuario, int id)
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        usuarioDAO.Atualizar(usuario, id);
    }
    public void ListarTodosUsuarios()
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        usuarioDAO.ListarTodos();
    }
    public void ListarUsuario(int id)
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        usuarioDAO.Listar(id);
    }
}