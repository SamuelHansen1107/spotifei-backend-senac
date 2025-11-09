
public class ArtistaDAO : IDAO<Artista>
{
    private SpotifeyContext context = new SpotifeyContext();
    public void Atualizar(Artista objeto)
    {
        context.Artistas.Update(objeto);
        context.SaveChanges();
    }

    public void Cadastrar(Artista objeto)
    {
        context.Artistas.Add(objeto);
        context.SaveChanges();
    }

    public void Excluir(Artista objeto)
    {
        context.Artistas.Remove(objeto);
        context.SaveChanges();
    }

    public Artista ListarPorId(int id)
    {
        context.Artistas.Find(id);
        return context.Artistas.FirstOrDefault(a => a.Id == id);
    }

    public List<Artista> ListarTodos()
    {
        return context.Artistas.ToList();
    }
}