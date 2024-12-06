using System;
using System.Collections.Generic;

namespace Sistema_de_Facturacion.Modelos;

public partial class Cliente
{
    public int ClienteId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string? Correo { get; set; }

    public string Telefono { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string IdentificacionFiscal { get; set; } = null!;

    public DateTime FechaDeRegistro { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
