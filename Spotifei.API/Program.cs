using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var musicaGroup = app.MapGroup("/musicas");

// ========== //

app.MapGet("/", () =>
{
    List<Musica> musicas;
    musicas = new MusicaController().
}