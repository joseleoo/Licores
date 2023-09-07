namespace Licores.Models
{
    public class ProductoModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        //public TipoLicor Tipo { get; set; }
        // Otras propiedades comunes para todos los productos

        // Relación con la tabla de inventario
        //public ICollection<InventarioModel> Inventario { get; set; }
    }
}
