public class Playlist
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public Usuario? usuario { get; set; }
    public int IdUsuario { get; set; }
    public DateTime DataCriacao { get; set; }
    
}