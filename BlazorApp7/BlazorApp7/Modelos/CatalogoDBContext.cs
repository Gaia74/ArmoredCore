using Catalogo.Modelos;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp7.Modelos
{
    public class CatalogoDBContext : DbContext
    {
        public CatalogoDBContext(DbContextOptions<CatalogoDBContext> options) : base(options)
        {
        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Piloto> Pilotos { get; set; }
        public DbSet<ArmoredCore> ArmoredCores { get; set; }
        public DbSet<Parte> Partes { get; set; }
        public DbSet<Mision> Misiones { get; set; }
    }
}
