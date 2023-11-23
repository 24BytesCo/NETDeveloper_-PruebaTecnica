using Microsoft.EntityFrameworkCore;
using NETDeveloper__PruebaTecnica.Domain;

namespace NETDeveloper__PruebaTecnica.Persistence
{
    public class NETDeveloper_PruebaTecnicaDbContext : DbContext
    {
        public NETDeveloper_PruebaTecnicaDbContext(DbContextOptions<NETDeveloper_PruebaTecnicaDbContext> options) : base(options)
        {

        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
