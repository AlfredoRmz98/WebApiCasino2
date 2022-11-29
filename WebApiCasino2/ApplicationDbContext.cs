using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApiCasino2.Entidades;

namespace WebApiCasino2
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ParticipanteRifa>()
                .HasKey(al => new { al.ParticipanteId, al.RifaId });
            modelBuilder.Entity<PremioRifa>()
                .HasKey(al => new { al.RifaId, al.PremioNombre });
        }
        public DbSet<Baraja> Barajas { get; set; }
        public DbSet<ParticipanteRifa> ParticipanteRifa { get; set; }
        public DbSet<Participante> Participantes { get; set; }
        public DbSet<Rifa> Rifas { get; set; }
        public DbSet<PremioRifa> PremioRifa { get; set; }
        public DbSet<Premio> Premios  { get; set; }

    }
}
