using System.ComponentModel.DataAnnotations;
namespace Catalogo.Modelos
{
    public class Empresa
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La sede es requerida")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Sede { get; set; }
        [Required(ErrorMessage = "La ocupación es requerida")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Ocupación { get; set; }
    }
}