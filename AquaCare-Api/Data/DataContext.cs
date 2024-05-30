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

        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Local> Locais { get; set; }
        public DbSet<Indicador> Indicadores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }

}
