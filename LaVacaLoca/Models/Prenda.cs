using System.ComponentModel.DataAnnotations;
namespace LaVacaLoca.Models
{
    public class Prenda
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaDeLanzamiento { get; set; }
        public string? TipoDePrenda { get; set; }

        public string? Talla { get; set; }
        public decimal Precio { get; set; }
    }
}
