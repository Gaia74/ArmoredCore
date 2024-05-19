using Catalogo.Modelos;

namespace BlazorApp7.Repositorio
{
    public interface IRepositorioPilotos
    {
        Task<List<Piloto>> GetAll();
        Task<Piloto?> Get(int id);
        Task<Piloto> Add(Piloto piloto);
        Task Update(int id, Piloto piloto);
        Task Delete(int id);
    }
}
