using Sistema_de_Facturacion.Abstraccion.Repositorios;
using Sistema_de_Facturacion.Abstraccion.Servicios;
using Sistema_de_Facturacion.DTO.DetalleFacturaDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Implementaciones.Servicios
{
    public class ServicioDetalleFactura : IServicioDetalleFactura
    {

        private readonly IRepositorioDetalleFactura _repositorioDetalleFactura;
        public ServicioDetalleFactura(IRepositorioDetalleFactura repositorioDetalleFactura)
        {
            _repositorioDetalleFactura = repositorioDetalleFactura;
        }


        public DetalleFacturaDTO Create(CrearDetalleFacturaDTO creardetalleFacturaDTO)
        {
            var Dfactura = _repositorioDetalleFactura.Create(creardetalleFacturaDTO);
            var DfacturaDTO = new DetalleFacturaDTO
            {
                FacturaId=Dfactura.FacturaId,
                ProductoId=Dfactura.ProductoId,
                Cantidad=Dfactura.Cantidad,
                PrecioUnitario=Dfactura.PrecioUnitario,
                SubTotal=Dfactura.SubTotal,
            };
            return DfacturaDTO;
        }

        public void Delete(int id)
        {
            _repositorioDetalleFactura.Delete(id);
        }

        public DetalleFactura GetById(int id)
        {
           return _repositorioDetalleFactura.GetById(id);
        }

        public List<DetalleFacturaDTO> GetDetalleFactura()
        {
            var Dfactutas = _repositorioDetalleFactura.GetDetalleFactura();
            var DfacturaDTO = new List<DetalleFacturaDTO>();
            foreach (DetalleFactura detalleFactura in Dfactutas)
            {
                var nuevoDfacturaDTO = new DetalleFacturaDTO
                {

                    DetalleId=detalleFactura.DetalleId,
                    FacturaId =detalleFactura.FacturaId,
                    ProductoId = detalleFactura.ProductoId,
                    Cantidad=detalleFactura.Cantidad,
                    PrecioUnitario=detalleFactura.PrecioUnitario,
                    SubTotal=detalleFactura.SubTotal,
                };
                DfacturaDTO.Add(nuevoDfacturaDTO);

            };
            return DfacturaDTO;
        }

        public DetalleFacturaDTO Update(int id, ActualizarDetalleFacturaDTO actualizardetalleFacturaDTO)
        {
            var Dfacturas = _repositorioDetalleFactura.Update(id, actualizardetalleFacturaDTO);
            var DfacturaDTO = new DetalleFacturaDTO
            {
                FacturaId=Dfacturas.FacturaId,
                ProductoId=Dfacturas.ProductoId,
                Cantidad=Dfacturas.Cantidad,
                PrecioUnitario=Dfacturas.PrecioUnitario,
                SubTotal = Dfacturas.SubTotal,
            };

            return DfacturaDTO;
        }
    }
}
