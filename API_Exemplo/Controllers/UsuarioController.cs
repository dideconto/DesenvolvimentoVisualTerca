using System;
using System.Collections.Generic;
using System.Linq;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {

        private static List<Usuario> usuarios = new List<Usuario>();

        // GET: /api/usuario/listar
        [HttpGet]
        [Route("listar")]
        public IActionResult Listar()
        {
            return Ok(usuarios);
        }

        // POST: /api/usuario/cadastrar
        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Usuario usuario)
        {
            usuarios.Add(usuario);
            return Created("", usuario);
        }

        // GET: /api/usuario/buscar
        [HttpGet]
        [Route("buscar/{email}")]
        public IActionResult Buscar([FromRoute] string email)
        {
            Usuario usuario = usuarios.FirstOrDefault
            (
                u => u.Email.Equals(email)
            );
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }
    }
}