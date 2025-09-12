public class PlaylistDAO : IDAO<Playlist>
{
    private static List<Playlist> playlists = new List<Playlist>();
    public List<Musica> Musicas { get; set; }
    public void Atualizar(Playlist objeto,int id)
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