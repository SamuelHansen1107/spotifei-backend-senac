public class Musica
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public TimeSpan Duracao { get; set; }
    public Artista? Artista { get; set; }
    public Album? Album { get; set; }
    public int AlbumId { get; set; }
    public int ArtistaId { get; set; }

    /*public Musica()
    {

    }*/
}