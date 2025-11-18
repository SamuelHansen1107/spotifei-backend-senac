
public class MusicaDAO : IDAO<Musica>
{
    private SpotifeyContext context = new SpotifeyContext();
    public void Atualizar(Musica objeto)
    {
        context.Musicas.Update(objeto);
        context.SaveChanges();
    }

    public void Cadastrar(Musica objeto)
    {
        context.Musicas.Add(objeto);
        context.SaveChanges();
    }

    public void Excluir(Musica objeto)
    {
        context.Musicas.Remove(objeto);
        context.SaveChanges();
    }

    public Musica ListarPorId(int id)
    {
        Musica? musica = null;
        musica = context.Musicas.FirstOrDefault(m => m.Id == id);
        return musica;
    }

    public List<Musica> ListarTodos()
    {
        return context.Musicas.ToList();
    }
}