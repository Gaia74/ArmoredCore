using BlazorApp7.Modelos;
using BlazorApp7.Repositorio;
using Catalogo.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Catalogo.Repositorio
{
    public class RepositorioPilotos : IRepositorioPilotos
    {
        private readonly CatalogoDBContext _context;

        public RepositorioPilotos(CatalogoDBContext context)
        {
            _context = context;
        }

        public async Task<Piloto> Add(Piloto piloto)
        {
            await _context.Pilotos.AddAsync(piloto);
            await _context.SaveChangesAsync();
            return piloto;
        }

        public async Task Delete(int id)
        {
            var piloto = await _context.Pilotos.FindAsync(id);
            if (piloto != null)
            {
                _context.Pilotos.Remove(piloto);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Piloto>> GetAll()
        {
            return await _context.Pilotos.ToListAsync();
        }

        public async Task<Piloto?> Get(int id)
        {
            return await _context.Pilotos.FindAsync(id);
        }

        public async Task Update(int id, Piloto piloto)
        {
            var pilotoactual = await _context.Pilotos.FindAsync(id);
            if (pilotoactual != null)
            {
                pilotoactual.Nombre = piloto.Nombre;
                pilotoactual.Ocupación = piloto.Ocupación;
                pilotoactual.RangoArena = piloto.RangoArena;
                pilotoactual.Empresa = piloto.Empresa;
                await _context.SaveChangesAsync();
            }
        }

    }
}