namespace Sistema_de_Facturacion.DTO.PagoDTO
{
    public class ActualizarPagoDTO
    {
        public int FacturaId { get; set; }

        public decimal Monto { get; set; }

        public DateTime FechaDePago { get; set; }

        public string MetodoDePago { get; set; } = null!;
    }
}
