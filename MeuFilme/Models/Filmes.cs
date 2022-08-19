using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuFilme.Models
{
    public class Filmes
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string? Titulo { get; set; }

        [Display(Name = "Data de lançamento")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string? Genero { get; set; }

        [Range(1, 100), DataType(DataType.Currency)]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Preco { get; set; }
    }
}
