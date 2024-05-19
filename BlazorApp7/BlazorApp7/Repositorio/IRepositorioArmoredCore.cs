using Catalogo.Modelos;

namespace BlazorApp7.Repositorio
{
    public interface IRepositorioArmoredCores
    {
        Task<List<ArmoredCore>> GetAll();
        Task<ArmoredCore?> Get(int id);
        Task<ArmoredCore> Add(ArmoredCore armoredcore);
        Task Update(int id, ArmoredCore armoredcore);
        Task Delete(int id);
    }
}
