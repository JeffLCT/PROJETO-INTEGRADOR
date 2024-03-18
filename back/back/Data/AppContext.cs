using back.Models;
using Microsoft.EntityFrameworkCore;

namespace back.Data
{
    public class AppContext: DbContext
    {
        public AppContext(DbContextOptions<AppContext>opts):base(opts){ }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Estacionamento> Estacionamentos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
