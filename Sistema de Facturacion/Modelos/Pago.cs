using System;
using System.Collections.Generic;

namespace Sistema_de_Facturacion.Modelos;

public partial class Pago
{
    public int PagoId { get; set; }

    public int FacturaId { get; set; }

    public decimal Monto { get; set; }

    public DateTime FechaDePago { get; set; }

    public string MetodoDePago { get; set; } = null!;

    public virtual Factura Factura { get; set; } = null!;
}
