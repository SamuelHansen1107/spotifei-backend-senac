
public class UsuarioDAO : IDAO<Usuario>
{
    private List<Usuario> usuarios = new List<Usuario>();
    public void Atualizar(Usuario objeto,int id)
    {
        usuarios.Remove(usuarios.Single(item => item.Id == id));
        usuarios.Add(objeto);
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
        return usuarios.SingleOrDefault(item => item.Id == id);
    }

    public List<Usuario> ListarTodos()
    {
        return usuarios;
    }
}