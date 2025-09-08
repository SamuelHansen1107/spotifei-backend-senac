public class Album
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public DateTime DataLancamento{ get; set; }
    public int ArtistaId { get; set; }

    public Album(string titulo, DateTime dataLancamento, int artistaId)
    {
        Titulo = titulo;
        DataLancamento = dataLancamento;
        ArtistaId = artistaId;
    }
}