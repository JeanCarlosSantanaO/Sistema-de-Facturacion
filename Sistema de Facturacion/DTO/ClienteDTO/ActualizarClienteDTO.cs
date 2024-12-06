namespace Sistema_de_Facturacion.DTO.ClienteDTO
{
    public class ActualizarClienteDTO
    {
        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string? Correo { get; set; }

        public string Telefono { get; set; } = null!;

        public string Direccion { get; set; } = null!;

        public string IdentificacionFiscal { get; set; } = null!;
    }
}
