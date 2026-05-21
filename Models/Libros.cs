using System.ComponentModel.DataAnnotations;


namespace Repaso2.Models

{
    public class Libros: Productos
    {
        public string Editorial { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
    }
}
