using System.ComponentModel.DataAnnotations;

namespace Repaso2.Models

{
    public class Electronicos : Productos
    {
        [Required(ErrorMessage = "El tiempo de garantía del electrónico es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El tiempo de garantía debe de ser mayor a 0")]

        public int tiempoGarantia { get; set; }

        [Required(ErrorMessage = "El voltaje del electrónico es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El voltaje debe de ser mayor a 0")]
        public int voltaje { get; set; }
    }

}