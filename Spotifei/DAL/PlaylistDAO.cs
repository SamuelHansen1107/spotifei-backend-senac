
public class PlaylistDAO : IDAO<Playlist>
{
    private static List<Playlist> playlists = new List<Playlist>();
    public void Atualizar(Playlist objeto)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Playlist objeto)
    {
        playlists.Add(objeto);
    }

    public void Excluir(int id)
    {
        throw new NotImplementedException();
    }

    public Playlist Listar(int id)
    {
        throw new NotImplementedException();
    }

    public List<Playlist> ListarTodos()
    {
        return playlists;
    }
}