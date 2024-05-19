using Catalogo.Modelos;

namespace BlazorApp7.Repositorio
{
    public interface IRepositorioEmpresas
    {
        Task<List<Empresa>> GetAll();
        Task<Empresa?> Get(int id);
        Task<Empresa> Add(Empresa empresa);
        Task Update(int id, Empresa empresa);
        Task Delete(int id);
    }
}
