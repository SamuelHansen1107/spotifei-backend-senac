public class Artista
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Genero { get; set; }

    public Artista(string nome, string genero)
    {
        Nome = nome;
        Genero = genero;
    }
}