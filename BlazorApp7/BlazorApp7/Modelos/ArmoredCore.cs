using System.ComponentModel.DataAnnotations;
namespace Catalogo.Modelos
{
    public class ArmoredCore
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Nombre { get; set; }

        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? ArmaIzq { get; set; }

        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? ArmaDer { get; set; }

        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? HombroIzq { get; set; }

        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? HombroDer { get; set; }
    }
}