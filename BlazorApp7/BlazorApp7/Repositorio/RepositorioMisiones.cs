using BlazorApp7.Modelos;
using BlazorApp7.Repositorio;
using Catalogo.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Catalogo.Repositorio
{
    public class RepositorioMisiones : IRepositorioMisiones
    {
        private readonly CatalogoDBContext _context;

        public RepositorioMisiones(CatalogoDBContext context)
        {
            _context = context;
        }

        public async Task<Mision> Add(Mision mision)
        {
            await _context.Misiones.AddAsync(mision);
            await _context.SaveChangesAsync();
            return mision;
        }

        public async Task Delete(int id)
        {
            var mision = await _context.Misiones.FindAsync(id);
            if (mision != null)
            {
                _context.Misiones.Remove(mision);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Mision>> GetAll()
        {
            return await _context.Misiones.ToListAsync();
        }

        public async Task<Mision?> Get(int id)
        {
            return await _context.Misiones.FindAsync(id);
        }

        public async Task Update(int id, Mision mision)
        {
            var misionactual = await _context.Misiones.FindAsync(id);
            if (misionactual != null)
            {
                misionactual.Piloto = mision.Piloto;
                misionactual.Nombre = mision.Nombre;
                misionactual.Descripcion = mision.Descripcion;
                misionactual.Recompensa = mision.Recompensa;
                await _context.SaveChangesAsync();
            }
        }

    }
}