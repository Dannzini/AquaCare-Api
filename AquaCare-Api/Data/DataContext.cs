using Microsoft.EntityFrameworkCore;
using AquaCare_Api.Model;

namespace AquaCareAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Indicador> Indicadores { get; set; }
        public DbSet<Local> Locais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasKey(u => u.CodigoUsuario);

            modelBuilder.Entity<Cidade>()
                .HasKey(c => c.CodigoCidade);

            modelBuilder.Entity<Indicador>()
                .HasKey(i => i.CodigoIndicador);

            modelBuilder.Entity<Local>()
                .HasKey(l => l.CodigoLocal);
        }
    }
}
