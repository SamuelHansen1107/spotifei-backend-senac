public class MusicaController
{
    private MusicaDAO musicaDAO = new MusicaDAO();

    public void AdicionarMusica(Musica musica)
    {
        musicaDAO.Cadastrar(musica);
    }
    public void RemoverMusica(Musica musica)
    {
        musicaDAO.Excluir(musica);
    }
    public void AtualizarMusica(Musica musica)
    {
        musicaDAO.Atualizar(musica);
    }
    public List<Musica>ListarTodasMusicas()
    {
        return musicaDAO.ListarTodos();
    }
    public Musica? ListarMusicaPorId(int id)
    {
        Musica musica = musicaDAO.ListarPorId(id);
        if (musica != null)
        {
            return musica;
        }
        else
        {
            return null;
        }
    }
}