class AlbumController
{
    public bool VerificarSeExisteAlbum(int id)
    {
        AlbumDAO dao = new AlbumDAO();
        var album = dao.Listar(id);
        return album != null;
    }

    public void AdicionarAlbum(Album album)
    {
        AlbumDAO dao = new AlbumDAO();
        dao.Cadastrar(album);
    }

    public void RemoverAlbum(int id)
    {
        AlbumDAO dao = new AlbumDAO();
        dao.Excluir(id);
    }

    public void AtualizarAlbum(Album album, int id)
    {
        AlbumDAO dao = new AlbumDAO();
        dao.Atualizar(album, id);
    }

    public void ListarTodosAlbums(int id)
    {
        AlbumDAO dao = new AlbumDAO();
        dao.ListarTodos();
    }

    public void ListarAlbum(int id)
    {
        AlbumDAO dao = new AlbumDAO();
        dao.Listar(id);
    }
}