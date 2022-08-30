using System.Collections.Generic;
using System.Linq;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/funcionario")]
    public class FuncionarioController : ControllerBase
    {
        private static List<Funcionario> funcionarios = new List<Funcionario>();

        // GET: /api/funcionario/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            return Ok(funcionarios);
        }

        // POST: /api/funcionario/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
            return Created("", funcionario);
        }

        // GET: /api/funcionario/buscar/{cpf}
        [HttpGet]
        [Route("buscar/{cpf}")] 
        public IActionResult Buscar([FromRoute] string cpf)
        {
            Funcionario funcionario = funcionarios.FirstOrDefault
            (
                f => f.Cpf.Equals(cpf)
            );
            if (funcionario == null)
            {
                return NotFound();
            }
            return Ok(funcionario);
        }
    }
}