using System.ComponentModel.DataAnnotations;
namespace Catalogo.Modelos
{
    public class Mision
    {
        public int Id { get; set; }
        public Piloto? Piloto { get; set; }
        [Required(ErrorMessage = "El nombre de la mision es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La descripcion de la mision es requerida")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "La recompensa es requerida")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Recompensa { get; set; }
    }
}