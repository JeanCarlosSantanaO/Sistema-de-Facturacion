using System;
using System.Collections.Generic;

namespace Sistema_de_Facturacion.Modelos;

public partial class Factura
{
    public int FacturaId { get; set; }

    public int ClienteId { get; set; }

    public string NumeroFactura { get; set; } = null!;

    public DateTime FechaEmision { get; set; }

    public decimal TotalBruto { get; set; }

    public decimal ImpuestoTotal { get; set; }

    public decimal TotalNeto { get; set; }

    public string Estado { get; set; } = null!;

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
