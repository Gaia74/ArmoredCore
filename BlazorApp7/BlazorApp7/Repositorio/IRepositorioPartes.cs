using Catalogo.Modelos;

namespace BlazorApp7.Repositorio
{
    public interface IRepositorioPartes
    {
        Task<List<Parte>> GetAll();
        Task<Parte?> Get(int id);
        Task<Parte> Add(Parte parte);
        Task Update(int id, Parte parte);
        Task Delete(int id);
    }
}
