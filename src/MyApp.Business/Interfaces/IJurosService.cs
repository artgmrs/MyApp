using MyApp.Business.Models;

namespace MyApp.Business.Interfaces
{
    public interface IJurosService
    {
        public Juros RetornaValorJuros();

        public string CalculaJuros(ParametrosCalculo parametros);
    }
}
