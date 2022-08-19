using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MeuFilme.Models
{
    public class FilmesGenreViewModel
    {
        public List<Filmes>? Filmes { get; set; }
        public SelectList? Genero { get; set; }
        public string? FilmeGenero { get; set; }
        public string? SearchString { get; set; }
    }
}
