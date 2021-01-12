using MyApp.Business.Interfaces;
using MyApp.Business.Models;
using System;

namespace MyApp.Business.Services
{
    public class JurosService : IJurosService
    {
        public string CalculaJuros(ParametrosCalculo parametros)
        {
            Juros valorJuros = RetornaValorJuros();

            string soma = Math.Pow(
                (double)parametros.ValorInicial * (1 + valorJuros.ValorJuros),
                parametros.Meses).ToString();

            decimal somaTruncada;
            string subString;

            if (soma.Length < 5)
            {
                somaTruncada = Convert.ToDecimal(soma) / 100;
            }
            else
            {
                subString = soma.Substring(0, 5);
                somaTruncada = Convert.ToDecimal(subString) / 100;
            }

            var resultado = somaTruncada.ToString("F2");

            return resultado;

        }

        public Juros RetornaValorJuros()
        {
            Juros juros = new Juros();
            return juros;
        }
    }
}
