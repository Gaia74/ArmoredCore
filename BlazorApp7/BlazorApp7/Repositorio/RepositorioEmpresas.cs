using BlazorApp7.Modelos;
using BlazorApp7.Repositorio;
using Catalogo.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Catalogo.Repositorio
{
    public class RepositorioEmpresas : IRepositorioEmpresas
    {
        private readonly CatalogoDBContext _context;

        public RepositorioEmpresas(CatalogoDBContext context)
        {
            _context = context;
        }

        public async Task<Empresa> Add(Empresa empresa)
        {
            await _context.Empresas.AddAsync(empresa);
            await _context.SaveChangesAsync();
            return empresa;
        }

        public async Task Delete(int id)
        {
            var empresa = await _context.Empresas.FindAsync(id);
            if (empresa != null)
            {
                _context.Empresas.Remove(empresa);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Empresa>> GetAll()
        {
            return await _context.Empresas.ToListAsync();
        }

        public async Task<Empresa?> Get(int id)
        {
            return await _context.Empresas.FindAsync(id);
        }

        public async Task Update(int id, Empresa empresa)
        {
            var empresaactual = await _context.Empresas.FindAsync(id);
            if (empresaactual != null)
            {
                empresaactual.Nombre = empresa.Nombre;
                empresaactual.Sede = empresa.Sede;
                empresaactual.Ocupación = empresa.Ocupación;
                await _context.SaveChangesAsync();
            }
        }

    }
}