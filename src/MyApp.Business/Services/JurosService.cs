using MyApp.Business.Interfaces;
using MyApp.Business.Models;
using System;

namespace MyApp.Business.Services
{
    public class JurosService : IJurosService
    {
        public double CalculaJuros(ParametrosCalculo parametros)
        {
            var porcentagem = Math.Pow(
                (1 + Juros.ValorJuros), parametros.Meses);

            var resultado = parametros.ValorInicial * porcentagem;

            return Math.Truncate(resultado * 100) / 100;
        }
    }
}
