using Catalogo.Modelos;

namespace BlazorApp7.Repositorio
{
    public interface IRepositorioMisiones
    {
        Task<List<Mision>> GetAll();
        Task<Mision?> Get(int id);
        Task<Mision> Add(Mision mision);
        Task Update(int id, Mision mision);
        Task Delete(int id);
    }
}
