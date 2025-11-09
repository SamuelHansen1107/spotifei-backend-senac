
public class UsuarioDAO : IDAO<Usuario>
{
    private SpotifeyContext context = new SpotifeyContext();
    public void Atualizar(Usuario objeto)
    {
        context.Usuarios.Update(objeto);
        context.SaveChanges();
    }

    public void Cadastrar(Usuario objeto)
    {
        context.Usuarios.Add(objeto);
        context.SaveChanges();
    }

    public void Excluir(Usuario objeto)
    {
        context.Usuarios.Remove(objeto);
        context.SaveChanges();
    }

    public Usuario ListarPorId(int id)
    {
        context.Usuarios.Find(id);
        return context.Usuarios.FirstOrDefault(u => u.Id == id);
    }

    public List<Usuario> ListarTodos()
    {
        return context.Usuarios.ToList();
    }
}