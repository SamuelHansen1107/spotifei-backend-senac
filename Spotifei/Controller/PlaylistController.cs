public class PlaylistController
{
    private PlaylistDAO playlistDAO = new PlaylistDAO();
    public void AdicionarPlaylist(Playlist playlist)
    {
        playlistDAO.Cadastrar(playlist);
    }
    public void RemoverPlaylist(Playlist playlist)
    {
        playlistDAO.Excluir(playlist);
    }
    public void AtualizarPlaylist(Playlist playlist)
    {
        playlistDAO.Atualizar(playlist);
    }
    public List<Playlist> ListarTodasPlaylists()
    {
        return playlistDAO.ListarTodos();
    }
    public Playlist? ListarPlaylistPorId(int id)
    {
        Playlist playlist = playlistDAO.ListarPorId(id);
        if (playlist != null)
        {
            return playlist;
        }
        else
        {
            return null;
        }
    }
}