namespace Sistema_de_Facturacion.DTO.DetalleFacturaDTO
{
    public class ActualizarDetalleFacturaDTO
    {     

        public int FacturaId { get; set; }

        public int ProductoId { get; set; }

        public int Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal SubTotal { get; set; }
    }
}
