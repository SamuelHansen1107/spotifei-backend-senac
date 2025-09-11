
public class ArtistaDAO : IDAO<Artista>
{
    private static List<Artista> artistas = new List<Artista>();
    public void Atualizar(Artista objeto)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Artista objeto)
    {
        artistas.Add(objeto);
    }

    public void Excluir(int id)
    {
        throw new NotImplementedException();
    }

    public Artista Listar(int id)
    {
        throw new NotImplementedException();
    }

    public List<Artista> ListarTodos()
    {
        return artistas;
    }
}