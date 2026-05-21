using System.ComponentModel.DataAnnotations;
namespace Repaso2.Models

{

    public class Productos
    {
        public string CodigoProducto { get; set; } = string.Empty;
        public string NombreProducto { get; set; } = string.Empty;
        public string DescripcionProducto { get; set; } = string.Empty;

        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }

    }
}
