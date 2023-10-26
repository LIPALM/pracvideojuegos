using Microsoft.AspNetCore.Mvc;
using VideoJuego.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioControle : ControllerBase
    {
        private readonly ILogger<UsuarioControle> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public UsuarioControle(
            ILogger<UsuarioControle> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Usuario usuario)
        {
            _aplicacionContexto.Usuario.Add(usuario);
            _aplicacionContexto.SaveChanges();
            return Ok(usuario);
        }
        //READ: Obtener lista de estudiantes
        //[Route("")]
        [HttpGet]

        public IEnumerable<Usuario> Get()
        {
            return _aplicacionContexto.Usuario.ToList();
        }

        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Usuario usuario)
        {
            _aplicacionContexto.Usuario.Update(usuario);
            _aplicacionContexto.SaveChanges();
            return Ok(usuario);

        }
        //Delete: Eliminar estudiantes
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int usuarioID)
        {
            _aplicacionContexto.Usuario.Remove(
                _aplicacionContexto.Usuario.ToList()
                .Where(x=>x.idUsuario == usuarioID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(usuarioID);
        }
    }
}