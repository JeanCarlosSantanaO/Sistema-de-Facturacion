namespace Sistema_de_Facturacion.DTO.FacturaDTO
{
    public class FacturaDTO
    {
        public int FacturaId { get; set; }

        public int ClienteId { get; set; }

        public string NumeroFactura { get; set; } = null!;

        public DateTime FechaEmision { get; set; }

        public decimal TotalBruto { get; set; }

        public decimal ImpuestoTotal { get; set; }

        public decimal TotalNeto { get; set; }

        public string Estado { get; set; } = null!;
    }
}
