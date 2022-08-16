using System;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        // GET: /api/usuario/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            Usuario usuario = new Usuario
            {
                Email = "diogo@diogo.com",
                Senha = "123456798"
            };
            return NotFound(usuario);
        }

        //Exercício 1: cadastrar um usuário recebendo as informações 
        //da URL
        //Exercício 2: cadastrar um usuário recebendo as informações 
        //da corpo da requisição
        [HttpPost]
        public IActionResult Cadastrar()
        {
            return null;
        }
    }
}