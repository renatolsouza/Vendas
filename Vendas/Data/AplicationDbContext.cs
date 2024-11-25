using Microsoft.EntityFrameworkCore;
using Vendas.Models.Cadastro;

namespace Vendas.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<EmpresaModel> Empresa { get; set; }
        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<CidadeModel> Cidade { get; set; }
        public DbSet<EstadoModel> Estado { get; set; }
        public DbSet<PaisModel> Pais { get; set; }

    }
}
