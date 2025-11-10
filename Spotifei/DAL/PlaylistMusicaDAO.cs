
public class PlaylistMusicaDAO : IDAO<PlaylistMusica>
{
    private SpotifeyContext context = new SpotifeyContext();
    public void Atualizar(PlaylistMusica objeto)
    {
        context.PlaylistMusicas.Update(objeto);
        context.SaveChanges();
    }

    public void Cadastrar(PlaylistMusica objeto)
    {
        context.PlaylistMusicas.Add(objeto);
        context.SaveChanges();
    }

    public void Excluir(PlaylistMusica objeto)
    {
        context.PlaylistMusicas.Remove(objeto);
        context.SaveChanges();
    }

    public PlaylistMusica ListarPorId(int id)
    {
        PlaylistMusica? playlistMusica = null;
        playlistMusica = context.PlaylistMusicas.FirstOrDefault(p => p.Id == id);
        return playlistMusica;
    }

    public List<PlaylistMusica> ListarTodos()
    {
        return context.PlaylistMusicas.ToList();
    }
}