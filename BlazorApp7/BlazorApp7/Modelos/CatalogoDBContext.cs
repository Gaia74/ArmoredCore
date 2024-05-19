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
    }
}
