using Sistema_de_Facturacion.Abstraccion.Repositorios;
using Sistema_de_Facturacion.DTO.DetalleFacturaDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Implementaciones.Repositorios
{
    public class RepositorioDetalleFactura : IRepositorioDetalleFactura
    {

        private readonly SistemaDeFacturacionContext _context;
        public RepositorioDetalleFactura(SistemaDeFacturacionContext context)
        {
            _context = context;
        }


        //public DetalleFactura Create(DetalleFacturaDTO creardetalleFacturaDTO)
        //{
        //    var Dfactura = new DetalleFactura
        //    {
        //        FacturaId=creardetalleFacturaDTO.FacturaId,
        //        ProductoId=creardetalleFacturaDTO.ProductoId,
        //        Cantidad=creardetalleFacturaDTO.Cantidad,
        //        PrecioUnitario=creardetalleFacturaDTO.PrecioUnitario,
        //        SubTotal=creardetalleFacturaDTO.SubTotal
        //    };
        //    _context.DetalleFacturas.Add(Dfactura);
        //    _context.SaveChanges();
        //    return Dfactura;
        //}

        public DetalleFactura Create(CrearDetalleFacturaDTO creardetalleFacturaDTO)
        {
            var Dfactura = new DetalleFactura
            {
                FacturaId = creardetalleFacturaDTO.FacturaId,
                ProductoId = creardetalleFacturaDTO.ProductoId,
                Cantidad = creardetalleFacturaDTO.Cantidad,
                PrecioUnitario = creardetalleFacturaDTO.PrecioUnitario,
                SubTotal = creardetalleFacturaDTO.SubTotal
            };
            _context.DetalleFacturas.Add(Dfactura);
            _context.SaveChanges();
            return Dfactura;
        }

        public void Delete(int id)
        {
            DetalleFactura detalleFactura = GetById(id);
            _context.Remove(detalleFactura);
            _context.SaveChanges();

        }

        public DetalleFactura GetById(int id)
        {
            return _context.DetalleFacturas.Where(f => f.FacturaId == id).FirstOrDefault();
        }

        public List<DetalleFactura> GetDetalleFactura()
        {
            return [.. _context.DetalleFacturas];
        }

        public DetalleFactura Update(int id,ActualizarDetalleFacturaDTO actualizarDetalleFacturaDTO)
        {
            var Dfacturaexiste = GetById(id);

            Dfacturaexiste.FacturaId=actualizarDetalleFacturaDTO.FacturaId;
            Dfacturaexiste.ProductoId=actualizarDetalleFacturaDTO.ProductoId;
            Dfacturaexiste.Cantidad=actualizarDetalleFacturaDTO .Cantidad;  
            Dfacturaexiste.PrecioUnitario=actualizarDetalleFacturaDTO.PrecioUnitario;
            Dfacturaexiste.SubTotal=actualizarDetalleFacturaDTO.SubTotal;

            _context.Update(Dfacturaexiste);
            _context.SaveChanges();
            var facturaActualizada = GetById(id);
            return facturaActualizada;
        }
    }
}
