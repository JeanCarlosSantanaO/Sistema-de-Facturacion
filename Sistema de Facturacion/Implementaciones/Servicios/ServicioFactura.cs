using Sistema_de_Facturacion.Abstraccion.Repositorios;
using Sistema_de_Facturacion.Abstraccion.Servicios;
using Sistema_de_Facturacion.DTO.FacturaDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Implementaciones.Servicios
{
    public class ServicioFactura : IServicioFactura
    {

        private readonly IRepositorioFactura _servicioFactura;
        public ServicioFactura(IRepositorioFactura servicioFactura)
        {
            _servicioFactura = servicioFactura;
        }


        public FacturaDTO Create(CrearFacturaDTO crearfacturaDTO)
        {
            var factura = _servicioFactura.Create(crearfacturaDTO);
            var facturaDTO = new FacturaDTO
            {
                ClienteId = factura.ClienteId,
                NumeroFactura = factura.NumeroFactura,
                FechaEmision = factura.FechaEmision,
                TotalBruto = factura.TotalBruto,
                ImpuestoTotal = factura.ImpuestoTotal,
                TotalNeto = factura.TotalNeto,
                Estado = factura.Estado,
            };
            return facturaDTO;
        }

        public void Delete(int id)
        {
            _servicioFactura.Delete(id);
        }

        public Factura GetById(int id)
        {
           return _servicioFactura.GetById(id);
        }

        public List<FacturaDTO> GetFactura()
        {
           var facturas = _servicioFactura.GetFacturas();
            var facturaDTO = new List<FacturaDTO>();
            foreach (Factura factura in facturas)
            {
                var nuevaFactura = new FacturaDTO
                {
                    FacturaId=factura.FacturaId,
                    ClienteId=factura.ClienteId,
                    NumeroFactura=factura.NumeroFactura,
                    FechaEmision=factura.FechaEmision,
                    TotalBruto=factura.TotalBruto,
                    ImpuestoTotal=factura.ImpuestoTotal,
                    TotalNeto=factura.TotalNeto,
                    Estado=factura.Estado,
                };
                facturaDTO.Add(nuevaFactura);
            }
            return facturaDTO;
          
        }

        public FacturaDTO Update(int id, ActualizarFacturaDTO actualizarFacturaDTO)
        {
            var facturas = _servicioFactura.Update(id, actualizarFacturaDTO);
            var facturaDTO = new FacturaDTO
            {
                ClienteId= facturas.ClienteId,
                NumeroFactura=facturas.NumeroFactura,
                FechaEmision=facturas.FechaEmision,
                TotalBruto=facturas.TotalBruto,
                ImpuestoTotal=facturas.ImpuestoTotal,
                TotalNeto=facturas.TotalNeto,
                Estado = facturas.Estado,
            };
            return facturaDTO;
        }
    }
}
