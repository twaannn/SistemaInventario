using System.ComponentModel.DataAnnotations;

namespace SistemaInventario.Modelos
{
    public class Marca
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(60, ErrorMessage = "El nombre debe ser máximo 60 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripción es requerido")]
        [MaxLength(100, ErrorMessage = "La descripción debe ser máximo 100 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El estado es requerido")]
        public bool Estado { get; set; }
    }
}
