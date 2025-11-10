public class PlaylistMusicaController
{
    private PlaylistMusicaDAO playlistMusicaDAO = new PlaylistMusicaDAO();
    public void AdicionarMusica(PlaylistMusica playlistMusica)
    {
        playlistMusicaDAO.Cadastrar(playlistMusica);
    }
    public void RemoverMusica(PlaylistMusica playlistMusica)
    {
        playlistMusicaDAO.Excluir(playlistMusica);
    }
    public void AtualizarPlaylist(PlaylistMusica playlistMusica)
    {
        playlistMusicaDAO.Atualizar(playlistMusica);
    }
    public List<PlaylistMusica> ListarTodasMusicas()
    {
        return playlistMusicaDAO.ListarTodos();
    }
    public PlaylistMusica? ListarMusicaPorId(int id)
    {
        PlaylistMusica playlistMusica = playlistMusicaDAO.ListarPorId(id);
        if (playlistMusica != null)
        {
            return playlistMusica;
        }
        else
        {
            return null;
        }
    }
}