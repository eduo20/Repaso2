using System.ComponentModel.DataAnnotations;

namespace Repaso2.Models

{
    public class Electronicos : Productos
    {
        public int TiempoGarantia { get; set; }

        public string Voltaje { get; set; } = string.Empty;
    }

}