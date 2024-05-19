using BlazorApp7.Modelos;
using BlazorApp7.Repositorio;
using Catalogo.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Catalogo.Repositorio
{
    public class RepositorioPartes : IRepositorioPartes
    {
        private readonly CatalogoDBContext _context;

        public RepositorioPartes(CatalogoDBContext context)
        {
            _context = context;
        }

        public async Task<Parte> Add(Parte parte)
        {
            await _context.Partes.AddAsync(parte);
            await _context.SaveChangesAsync();
            return parte;
        }

        public async Task Delete(int id)
        {
            var parte = await _context.Partes.FindAsync(id);
            if (parte != null)
            {
                _context.Partes.Remove(parte);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Parte>> GetAll()
        {
            return await _context.Partes.ToListAsync();
        }

        public async Task<Parte?> Get(int id)
        {
            return await _context.Partes.FindAsync(id);
        }

        public async Task Update(int id, Parte parte)
        {
            var parteactual = await _context.Partes.FindAsync(id);
            if (parteactual != null)
            {
                parteactual.IDEmpresa = parte.IDEmpresa;
                parteactual.Nombre = parte.Nombre;
                parteactual.Posicion = parte.Posicion;
                parteactual.TipoArma = parte.TipoArma;
                await _context.SaveChangesAsync();
            }
        }

    }
}