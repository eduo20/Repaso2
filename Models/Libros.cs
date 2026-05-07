using System.ComponentModel.DataAnnotations;


namespace Repaso2.Models

{
    public class Libros: Productos
    {
        [Required(ErrorMessage = "La editorial del libro es obligatoria")]
        public string editorial { get; set; } = string.Empty;

        [Required(ErrorMessage = "La categoría del libro es obligatoria")]
        public string categoria { get; set; } = string.Empty;

        [Required(ErrorMessage = "El autor del libro es obligatorio")]
        public string autor { get; set; } = string.Empty;
    }
}
