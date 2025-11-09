
public class AlbumDAO : IDAO<Album>
{
    private SpotifeyContext context = new SpotifeyContext();
    public void Atualizar(Album objeto)
    {
        context.Albuns.Update(objeto);
        context.SaveChanges();
    }

    public void Cadastrar(Album objeto)
    {
        context.Albuns.Add(objeto);
        context.SaveChanges();
    }

    public void Excluir(Album objeto)
    {
        context.Albuns.Remove(objeto);
        context.SaveChanges();
    }

    public Album ListarPorId(int id)
    {
        context.Albuns.Find(id);
        return context.Albuns.FirstOrDefault(a => a.Id == id);
    }

    public List<Album> ListarTodos()
    {
        return context.Albuns.ToList();
    }
}