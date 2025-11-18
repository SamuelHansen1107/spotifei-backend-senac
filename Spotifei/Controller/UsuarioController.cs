public class UsuarioController
{
    private UsuarioDAO usuarioDAO = new UsuarioDAO();
    public bool VerificarSeExisteUsuario(int id)
    {
        UsuarioDAO usuarioDAO = new UsuarioDAO();
        var usuario = usuarioDAO.ListarPorId(id);
        return usuario != null; // vai verificar se existe o usuario, caso exista ele retorna o usuario
    }
    public void AdicionarUsuario(Usuario usuario)
    {
        usuarioDAO.Cadastrar(usuario);
    }
    public void RemoverUsuario(Usuario usuario)
    {
        usuarioDAO.Excluir(usuario);
    }
    public void AtualizarUsuario(Usuario usuario)
    {
        usuarioDAO.Atualizar(usuario);
    }
    public List<Usuario> ListarTodosUsuarios()
    {
        List<Usuario> usuarios = new UsuarioDAO().ListarTodos();
        return usuarios;
    }
    public Usuario? ListarUsuario(int id)
    {
        Usuario usuario = usuarioDAO.ListarPorId(id);
        if (usuario != null)
        {
            return usuario;
        }
        else
        {
            return null;
        }
    }
}