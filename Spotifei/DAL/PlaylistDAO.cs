public class PlaylistDAO : IDAO<Playlist>
{
    private SpotifeyContext context = new SpotifeyContext();
    public void Atualizar(Playlist objeto)
    {
        context.Playlists.Update(objeto);
        context.SaveChanges();
    }

    public void Cadastrar(Playlist objeto)
    {
        context.Playlists.Add(objeto);
        context.SaveChanges();
    }

    public void Excluir(Playlist objeto)
    {
        context.Playlists.Remove(objeto);
    }

    public Playlist ListarPorId(int id)
    {
        context.Musicas.Find(id);
        return context.Playlists.FirstOrDefault(p => p.Id == id);
    }

    public List<Playlist> ListarTodos()
    {
        return context.Playlists.ToList();
    }
}