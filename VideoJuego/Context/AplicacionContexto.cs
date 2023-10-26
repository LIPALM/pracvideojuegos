using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace VideoJuego.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<VideoJuegos> VideoJuegos { get; set; }

    }
}
