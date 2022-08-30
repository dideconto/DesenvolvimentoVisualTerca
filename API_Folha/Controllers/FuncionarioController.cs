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
        public IActionResult Listar() => Ok(funcionarios);

        // POST: /api/funcionario/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Funcionario funcionario)
        {
            // DataContext ctx = new DataContext();
            // ctx.Funcionarios.Add(funcionario);

            funcionarios.Add(funcionario);
            return Created("", funcionario);
        }

        // GET: /api/funcionario/buscar/{cpf}
        [HttpGet]
        [Route("buscar/{cpf}")]
        public IActionResult Buscar([FromRoute] string cpf)
        {
            Funcionario funcionario = funcionarios.
                FirstOrDefault(f => f.Cpf.Equals(cpf));
            return funcionario != null ? Ok(funcionario) : NotFound();
        }

        // DELETE: /api/funcionario/deletar/{cpf}
        [HttpDelete]
        [Route("deletar/{cpf}")]
        public IActionResult Deletar([FromRoute] string cpf)
        {
            Funcionario funcionario = funcionarios.FirstOrDefault
            (
                f => f.Cpf.Equals(cpf)
            );
            if(funcionario != null)
            {
                funcionarios.Remove(funcionario);
                return Ok(funcionario);
            }
            return NotFound();
        }

        // PATCH: /api/funcionario/alterar
        [HttpPatch]
        [Route("alterar")]
        public IActionResult Alterar([FromBody] Funcionario funcionario)
        {
            Funcionario funcionarioEncontrado = funcionarios.FirstOrDefault
            (
                f => f.Cpf.Equals(funcionario.Cpf)
            );
            if(funcionarioEncontrado != null)
            {
                funcionarioEncontrado.Nome = funcionario.Nome;
                return Ok(funcionarioEncontrado);
            }
            return NotFound();
        }
    }
}