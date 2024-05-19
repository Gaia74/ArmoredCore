using System.ComponentModel.DataAnnotations;
namespace Catalogo.Modelos
{
    public class Parte
    {
        public int Id { get; set; }
        public required Empresa Empresa { get; set; }
        public int IDEmpresa { get; set; }
        [Required(ErrorMessage = "El nombre de la parte es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La posicion en el cuerpo del arma es requerida")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Posicion { get; set; }
        [Required(ErrorMessage = "El tipo de arma es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? TipoArma { get; set; }
    }
}