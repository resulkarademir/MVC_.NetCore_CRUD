using Microsoft.EntityFrameworkCore;

namespace Uygulama1.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=WORKSERVER; database=Uygulama1; integrated security=true; TrustServerCertificate=True;");
        }

        public DbSet<Birimler> Birimler { get; set; }
        public DbSet<Personeller> Personeller { get; set; }
    }
}
