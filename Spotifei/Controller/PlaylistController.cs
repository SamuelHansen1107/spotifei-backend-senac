class PlaylistController
{
    public bool VerificarSeExistePlaylist()
    {
        List<Playlist> playlists = new List<Playlist>();
        if (playlists.Count != 0)
        {
            return true;
        }
        return false;
    }
    public void AdicionarPlaylist(Playlist playlist)
    {
        List<Playlist> playlists = new List<Playlist>();
        playlists.Add(playlist);
    }
    public void RemoverPlaylist(Playlist playlist)
    {
        List<Playlist> playlists = new List<Playlist>();
        playlists.Remove(playlist);
    }
    public void AtualizarPlaylist(Playlist playlist)
    {
        List<Playlist> playlists = new List<Playlist>();
        playlists.Remove(playlist);
        playlists.Add(playlist);
    }
    public void ListarTodasPlaylists()
    {
        PlaylistDAO playlistDAO = new PlaylistDAO();
        playlistDAO.ListarTodos();
    }
    public void ListarPlaylist(int id)
    {
        PlaylistDAO playlistDAO = new PlaylistDAO();
        playlistDAO.ListarPorId(id);
    }
}