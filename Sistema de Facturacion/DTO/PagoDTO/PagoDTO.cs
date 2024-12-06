namespace Sistema_de_Facturacion.DTO.PagoDTO
{
    public class PagoDTO
    {
        public int PagoId { get; set; }

        public int FacturaId { get; set; }

        public decimal Monto { get; set; }

        public DateTime FechaDePago { get; set; }

        public string MetodoDePago { get; set; } = null!;
    }
}
