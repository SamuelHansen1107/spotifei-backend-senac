
public class ArtistaDAO : IDAO<Artista>
{
    private static List<Artista> artistas = new List<Artista>();
    public void Atualizar(Artista objeto,int id)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Artista objeto)
    {
        artistas.Add(objeto);
    }

    public void Excluir(int id)
    {
        artistas.Remove(artistas.Single(a => a.Id == id));
    }

    public Artista Listar(int id)
    {
        return artistas.SingleOrDefault(a => a.Id == id);
    }

    public List<Artista> ListarTodos()
    {
        return artistas;
    }
}