using System.ComponentModel.DataAnnotations;

namespace MyApp.Business.Models
{
    public class ParametrosCalculo
    {
        [Required]
        public double ValorInicial { get; set; }

        [Required]
        public int Meses { get; set; }

        public ParametrosCalculo(double valorInicial, int meses)
        {
            ValorInicial = valorInicial;
            Meses = meses;
        }
    }
}
