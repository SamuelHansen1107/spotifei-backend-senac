class ArtistaController
{
    public bool VerificarSeExisteArtista(int id)
    {
        ArtistaDAO dao = new ArtistaDAO();
        var artista = dao.Listar(id);
        return artista != null;
    }

    public void AdicionarArtista(Artista artista)
    {
        ArtistaDAO dao = new ArtistaDAO();
        dao.Cadastrar(artista);
    }

    public void RemoverArtista(int id)
    {
        ArtistaDAO dao = new ArtistaDAO();
        dao.Excluir(id);
    }

    public void AtualizarArtista(Artista artista, int id)
    {
        ArtistaDAO dao = new ArtistaDAO();
        dao.Atualizar(artista, id);
    }

    public void ListarTodosArtistas()
    {
        ArtistaDAO dao = new ArtistaDAO();
        dao.ListarTodos();
    }

    public void ListarArtista(int id)
    {
        ArtistaDAO dao = new ArtistaDAO();
        dao.Listar(id);
    }
}