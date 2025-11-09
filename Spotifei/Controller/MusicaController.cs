public class MusicaController
{
    private MusicaDAO musicaDAO = new MusicaDAO();
    public bool VerificarSeExisteMusica(int id)
    {
        List<Musica> musicas = new List<Musica>();
        if (musicas.Count != 0)
        {
            return true;
        }
        return false;
    }
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
        List<Musica> musicas = new MusicaDAO().ListarTodos();
        return musicas;
    }
    public Musica ListarMusicaPorId(int id)
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