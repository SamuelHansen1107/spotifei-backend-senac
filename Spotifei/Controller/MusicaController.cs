public class MusicaController
{
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
        List<Musica> musicas = new List<Musica>();
        musicas.Add(musica);
    }
    public void RemoverMusica(Musica musica)
    {
        List<Musica> musicas = new List<Musica>();
        musicas.Remove(musica);
    }
    public void AtualizarMusica(Musica musica)
    {
        List<Musica> musicas = new List<Musica>();
        musicas.Remove(musica);
        musicas.Add(musica);
    }
    public void ListarTodasMusicas()
    {
        MusicaDAO musicaDAO = new MusicaDAO();
        musicaDAO.ListarTodos();
    }
    public Musica ListarMusica(int id)
    {
        MusicaDAO musicaDAO = new MusicaDAO();
        return musicaDAO.Listar(id);
    }
}