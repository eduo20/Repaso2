using System.ComponentModel.DataAnnotations;

namespace Repaso2.Models
{

    public class Alimentos : Productos
    {
        public DateTime FechaVencimiento { get; set; }

        public string UnidadMedida { get; set; } = string.Empty;
    }
}
