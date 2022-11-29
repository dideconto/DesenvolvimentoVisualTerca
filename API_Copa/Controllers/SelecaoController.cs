using System.Collections.Generic;
using System.Linq;
using api.Models;
using API_Copa.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/selecao")]
    public class SelecaoController : ControllerBase
    {
        private readonly Context _context;
        public SelecaoController(Context context) =>
            _context = context;

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Selecao selecao)
        {
            _context.Selecoes.Add(selecao);
            _context.SaveChanges();
            return Created("", selecao);
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            List<Selecao> Selecaos = _context.Selecoes.ToList();
            return Selecaos.Count != 0 ? Ok(Selecaos) : NotFound();
        }

        // [HttpGet]
        // [Route("buscar/{cpf}/{mes}/{ano}")]
        // public IActionResult Listar(string cpf, int mes, int ano)
        // {
        //     Selecao Selecao = _context.Selecaos
        //         .Include(x => x.Funcionario)
        //         .FirstOrDefault
        //         (
        //             x => x.Funcionario.Cpf.Equals(cpf) &&
        //             x.Ano == ano &&
        //             x.Mes == mes
        //         );
        //     return Selecao != null ? Ok(Selecao) : NotFound();
        // }

        // [HttpGet]
        // [Route("filtrar/{mes}/{ano}")]
        // public IActionResult Filtrar(string cpf, int mes, int ano)
        // {
        //     List<Selecao> Selecaos = _context.Selecaos
        //         .Include(x => x.Funcionario)
        //         .Where
        //         (
        //             x =>
        //             x.Ano == ano &&
        //             x.Mes == mes
        //         ).ToList();
        //     return Selecaos.Count != 0 ? Ok(Selecaos) : NotFound();
        // }
    }
}