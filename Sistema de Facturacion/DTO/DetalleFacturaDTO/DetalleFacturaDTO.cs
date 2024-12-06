namespace Sistema_de_Facturacion.DTO.DetalleFacturaDTO
{
    public class DetalleFacturaDTO
    {
        public int DetalleId { get; set; }

        public int FacturaId { get; set; }

        public int ProductoId { get; set; }

        public int Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal SubTotal { get; set; }
    }
}
