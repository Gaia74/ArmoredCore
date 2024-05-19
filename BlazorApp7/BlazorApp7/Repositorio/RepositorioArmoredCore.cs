using BlazorApp7.Modelos;
using BlazorApp7.Repositorio;
using Catalogo.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Catalogo.Repositorio
{
    public class RepositorioArmoredCores : IRepositorioArmoredCores
    {
        private readonly CatalogoDBContext _context;

        public RepositorioArmoredCores(CatalogoDBContext context)
        {
            _context = context;
        }

        public async Task<ArmoredCore> Add(ArmoredCore armoredcore)
        {
            await _context.ArmoredCores.AddAsync(armoredcore);
            await _context.SaveChangesAsync();
            return armoredcore;
        }

        public async Task Delete(int id)
        {
            var armoredcore = await _context.ArmoredCores.FindAsync(id);
            if (armoredcore != null)
            {
                _context.ArmoredCores.Remove(armoredcore);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<ArmoredCore>> GetAll()
        {
            return await _context.ArmoredCores.ToListAsync();
        }

        public async Task<ArmoredCore?> Get(int id)
        {
            return await _context.ArmoredCores.FindAsync(id);
        }

        public async Task Update(int id, ArmoredCore armoredcore)
        {
            var armoredcoreactual = await _context.ArmoredCores.FindAsync(id);
            if (armoredcoreactual != null)
            {
                armoredcoreactual.Nombre = armoredcore.Nombre;
                armoredcoreactual.ArmaIzq = armoredcore.ArmaIzq;
                armoredcoreactual.ArmaDer = armoredcore.ArmaDer;
                armoredcoreactual.HombroIzq = armoredcore.HombroIzq;
                armoredcoreactual.HombroDer = armoredcore.HombroDer;
                await _context.SaveChangesAsync();
            }
        }

    }
}