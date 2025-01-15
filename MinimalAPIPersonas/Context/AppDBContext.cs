using Microsoft.EntityFrameworkCore;
using MinimalAPIPersonas.Model;

namespace MinimalAPIPersonas.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Persona> Personas { get; set; }
    }
}
 