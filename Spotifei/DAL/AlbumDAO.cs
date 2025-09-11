
public class AlbumDAO : IDAO<Album>
{
    private static List<Album> albums = new List<Album>();
    public void Atualizar(Album objeto,int id)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Album objeto)
    {
        albums.Add(objeto);
    }

    public void Excluir(int id)
    {
        throw new NotImplementedException();
    }

    public Album Listar(int id)
    {
        throw new NotImplementedException();
    }

    public List<Album> ListarTodos()
    {
        return albums;
    }
}