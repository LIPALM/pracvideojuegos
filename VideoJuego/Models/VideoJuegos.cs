using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace WebApplication2.Models
{
    public class VideoJuegos
    {
        [Key]
        public int idVideoJuego { get; set; }
        public string Nombre { get; set; }
        public bool  TipoDePago { get; set; }
        public string EsGrupal { get; set; }
        public string Tipo { get; set; }
        public int idUsuario { get; set; }
    }
}