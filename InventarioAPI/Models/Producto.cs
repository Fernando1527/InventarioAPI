using System.ComponentModel.DataAnnotations;

namespace InventarioAPI.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public decimal Precio { get; set; }

        public int Cantidad { get; set; }

        public int IdCategoria { get; set; }
    }
}