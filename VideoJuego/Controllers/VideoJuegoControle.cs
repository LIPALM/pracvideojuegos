using Microsoft.AspNetCore.Mvc;
using VideoJuego.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoJuegoControle : ControllerBase
    {
        private readonly ILogger<VideoJuegoControle> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public VideoJuegoControle(
            ILogger<VideoJuegoControle> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] VideoJuegos videojuego)
        {
            _aplicacionContexto.VideoJuegos.Add(videojuego);
            _aplicacionContexto.SaveChanges();
            return Ok(videojuego);
        }
        //READ: Obtener lista de estudiantes
        //[Route("")]
        [HttpGet]

        public IEnumerable<VideoJuegos> Get()
        {
            return _aplicacionContexto.VideoJuegos.ToList();
        }

        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] VideoJuegos videojuego)
        {
            _aplicacionContexto.VideoJuegos.Update(videojuego);
            _aplicacionContexto.SaveChanges();
            return Ok(videojuego);

        }
        //Delete: Eliminar estudiantes
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int videojuegoID)
        {
            _aplicacionContexto.VideoJuegos.Remove(
                _aplicacionContexto.VideoJuegos.ToList()
                .Where(x=>x.idVideoJuego == videojuegoID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(videojuegoID);
        }
    }
}