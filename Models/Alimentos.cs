using System.ComponentModel.DataAnnotations;

namespace Repaso2.Models
{

    public class Alimentos : Productos
    {
        [Required(ErrorMessage = "La fecha de vencimiento del alimento es obligatoria")]
        public DateTime fechaVencimiento { get; set; }

        [Required(ErrorMessage = "La unidad ")]
        public string unidadMedida{ get; set; } = string.Empty;
    }
}
