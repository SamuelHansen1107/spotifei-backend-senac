
public class MusicaDAO : IDAO<Musica>
{
    private static List<Musica> Musicas = new List<Musica>();
    public void Atualizar(Musica objeto,int id)
    {
        throw new NotImplementedException();
    }

    public void Cadastrar(Musica objeto)
    {
        Musicas.Add(objeto);
    }

    public void Excluir(int id)
    {
    
        Musicas.Remove(Musicas.Single(item => item.Id == id));
    
    }

    public Musica Listar(int id)
    {
        throw new NotImplementedException();
    }

    public List<Musica> ListarTodos()
    {
        return Musicas;
    }
}