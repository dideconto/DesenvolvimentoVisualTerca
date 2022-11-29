using System.Collections.Generic;
using System.Linq;
using api.Models;
using API_Copa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [ApiController]
    [Route("api/jogo")]
    public class JogoController : ControllerBase
    {
        private readonly Context _context;
        public JogoController(Context context) =>
            _context = context;

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Jogo jogo)
        {
            _context.Jogos.Add(jogo);
            _context.SaveChanges();
            return Created("", jogo);
        }

        [HttpPut]
        [Route("alterar")]
        public IActionResult Alterar([FromBody] Jogo jogo)
        {
            _context.Jogos.Update(jogo);
            _context.SaveChanges();
            return Created("", jogo);
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            List<Jogo> jogos = _context.Jogos.Include(x => x.SelecaoA).Include(x => x.SelecaoB).ToList();
            return jogos.Count != 0 ? Ok(jogos) : NotFound();
        }

        [HttpGet]
        [Route("buscar/{id}")]
        public IActionResult Buscar([FromRoute] int id)
        {
            Jogo jogo = _context.Jogos.
                Include(x => x.SelecaoA).
                Include(x => x.SelecaoB).
                FirstOrDefault(x => x.Id == id);
            return jogo != null ? Ok(jogo) : NotFound();
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