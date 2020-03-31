using Calculadora.Domains;
using Calculadora.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Controllers
{

    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        public ICalculadoraRepository _calculadoraRepository;

        public CalculadoraController()
        {
            
        }

        [HttpPost]
        public IActionResult Somar(Operacao operacao)
        {
            var soma = operacao.N1 + operacao.N2;
            return Ok(soma);
        }

        [HttpPost("Subt")]
        public IActionResult Subt(Operacao operacao)
        {
           var subt = operacao.N1 - operacao.N2;
            return Ok(subt);
        }

        [HttpPost("Mult")]
        public IActionResult Mult(Operacao operacao)
        {
            var mult = operacao.N1 * operacao.N2;
            return Ok(mult);
        }

        [HttpPost("div")]
        public IActionResult div(Operacao operacao)
        {
            var div = operacao.N1 / operacao.N2;
            return Ok(div);
        }
    }
}
