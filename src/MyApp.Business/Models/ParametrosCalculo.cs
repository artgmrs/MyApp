using System.ComponentModel.DataAnnotations;

namespace MyApp.Business.Models
{
    public class ParametrosCalculo
    {
        [Required]
        public decimal ValorInicial { get; set; }

        [Required]
        public int Meses { get; set; }

        public ParametrosCalculo(decimal valorInicial, int meses)
        {
            ValorInicial = valorInicial;
            Meses = meses;
        }
    }
}
