
public class UsuarioDAO : IDAO<Usuario>
{
    private List<Usuario> usuarios = new List<Usuario>();
    public void Atualizar(Usuario objeto)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Usuario objeto)
    {
        usuarios.Add(objeto);
    }

    public void Excluir(int id)
    {
        usuarios.Remove(usuarios.Single(item => item.Id == id));
    }

    public Usuario Listar(int id)
    {
        throw new NotImplementedException();
    }

    public List<Usuario> ListarTodos()
    {
        return usuarios;
    }
}