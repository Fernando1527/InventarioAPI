namespace InventarioWeb.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public decimal Precio { get; set; }

        public int Cantidad { get; set; }

        public int IdCategoria { get; set; }
    }
}