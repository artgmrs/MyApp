using MyApp.Business.Models;

namespace MyApp.Business.Interfaces
{
    public interface IJurosService
    {
        public double CalculaJuros(ParametrosCalculo parametros);
    }
}
