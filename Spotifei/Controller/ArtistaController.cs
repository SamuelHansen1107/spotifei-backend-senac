public class ArtistaController
{
    private ArtistaDAO artistaDAO = new ArtistaDAO();
    public bool VerificarSeExisteArtista(int id)
    {
        ArtistaDAO dao = new ArtistaDAO();
        var artista = dao.ListarPorId(id);
        return artista != null;
    }

    public void AdicionarArtista(Artista artista)
    {
        artistaDAO.Cadastrar(artista);
    }

    public void RemoverArtista(Artista artista)
    {
        artistaDAO.Excluir(artista);
    }

    public void AtualizarArtista(Artista artista)
    {
        artistaDAO.Atualizar(artista);
    }
    
    public List<Artista> ListarTodosArtistas()
    {
        List<Artista> artistas = new ArtistaDAO().ListarTodos();
        return artistas;
    }

    public Artista ListarArtista(int id)
    {
        Artista artista = artistaDAO.ListarPorId(id);
        if (artista != null)
        {
            return artista;
        }
        else
        {
            return null;
        }
    }
}