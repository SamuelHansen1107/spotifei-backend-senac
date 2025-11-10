class AlbumController
{
    private AlbumDAO albumDAO = new AlbumDAO();
    public bool VerificarSeExisteAlbum(int id)
    {
        var album = albumDAO.ListarPorId(id);
        return album != null;
    }

    public void AdicionarAlbum(Album album)
    {
        albumDAO.Cadastrar(album);
    }

    public void RemoverAlbum(Album album)
    {
       albumDAO.Excluir(album);
    }

    public void AtualizarAlbum(Album album)
    {
        albumDAO.Atualizar(album);
    }

    public List<Album> ListarTodosAlbums(int id)
    {
        return albumDAO.ListarTodos();
    }

    public Album? ListarAlbum(int id)
    {
        Album album = albumDAO.ListarPorId(id);
        if (album != null)
        {
            return album;
        }
        else
        {
            return null;
        }
    }
}