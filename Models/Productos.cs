using System.ComponentModel.DataAnnotations;
namespace Repaso2.Models

{

    public class Productos
    {
        [Required(ErrorMessage = "El codigo del producto es obligatorio")]
        public string codigoProducto { get; set; } = string.Empty;

        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        public string nombreProducto { get; set; } = string.Empty;

        [Required(ErrorMessage = "La descripción del producto es obligatoria")]
        public string caracteristicasProduc { get; set; } = string.Empty;

        [Required(ErrorMessage = "El precio de compra del producto es obligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio de compra debe ser mayor que cero")]
        public decimal precioCompra { get; set; }

        [Required(ErrorMessage = "El precio de venta del producto es obligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio de venta debe ser mayor que cero")]
        public decimal precioVenta { get; set; }

    }
}
