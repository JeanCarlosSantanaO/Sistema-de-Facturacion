using System;
using System.Collections.Generic;

namespace Sistema_de_Facturacion.Modelos;

public partial class Producto
{
    public int ProductoId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal PrecioUnitario { get; set; }

    public decimal Impuesto { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();
}
