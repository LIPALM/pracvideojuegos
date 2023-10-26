using Microsoft.AspNetCore.Mvc;
using VideoJuego.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailControle : ControllerBase
    {
        private readonly ILogger<EmailControle> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public EmailControle(
            ILogger<EmailControle> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Email email)
        {
            _aplicacionContexto.Email.Add(email);
            _aplicacionContexto.SaveChanges();
            return Ok(email);
        }
        //READ: Obtener lista de estudiantes
        //[Route("")]
        [HttpGet]

        public IEnumerable<Email> Get()
        {
            return _aplicacionContexto.Email.ToList();
        }

        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Email email
            )
        {
            _aplicacionContexto.Email.Update(email);
            _aplicacionContexto.SaveChanges();
            return Ok(email);

        }
        //Delete: Eliminar estudiantes
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int emialID)
        {
            _aplicacionContexto.Email.Remove(
                _aplicacionContexto.Email.ToList()
                .Where(x=>x.idEmail == emialID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(emialID);
        }
    }
}