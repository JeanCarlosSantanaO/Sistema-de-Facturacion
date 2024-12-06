namespace Sistema_de_Facturacion.DTO.ProductoDTO
{
    public class ActualizarProductoDTO
    {
        public string Nombre { get; set; } = null!;

        public string? Descripcion { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal Impuesto { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
