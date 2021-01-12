using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.API.ViewModels;
using MyApp.Business.Interfaces;
using MyApp.Business.Models;

namespace MyApp.API.Controllers
{
    [Route("api/calculajuros")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly IJurosService _jurosService;
        private readonly IValidador _validador;

        public CalculaJurosController(IJurosService jurosService,
                                      IValidador validador)
        {
            _jurosService = jurosService;
            _validador = validador;
        }

        /// <summary>
        /// Retorna o resultado do cálculo de juros a partir dos parâmetros recebidos
        /// </summary>
        /// <remarks>
        /// Request simples:
        /// 
        ///     {
        ///         "valorInicial": 100,
        ///         "meses": 5
        ///     } 
        /// 
        /// </remarks>
        [HttpGet("")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CalculaJuros(decimal valorInicial, int meses)
        {
            ParametrosCalculo parametros = new ParametrosCalculo(valorInicial, meses);

            var resultadoValidador = _validador.OperacaoValida(parametros);

            if (!resultadoValidador.IsValid) return BadRequest(new Retorno(false, "Algo deu errado", resultadoValidador.Errors));

            var valorFinal = _jurosService.CalculaJuros(parametros);

            return Ok(new Retorno(true, "O valor foi calculado com sucesso!", new { valorFinal }));
        }

        /// <summary>
        ///     Retorna a URL do código fonte no github
        /// </summary>
        [HttpGet("showmethecode")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ShowMeTheCode()
        {
            ShowMeTheCode code = new ShowMeTheCode();

            return Ok(new Retorno(true, "O código do github foi recebido com sucesso!", code));
        }
    }
}
