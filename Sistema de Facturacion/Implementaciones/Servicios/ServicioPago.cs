using Sistema_de_Facturacion.Abstraccion.Repositorios;
using Sistema_de_Facturacion.Abstraccion.Servicios;
using Sistema_de_Facturacion.DTO.PagoDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Implementaciones.Servicios
{
    public class ServicioPago : IServicioPago
    {
        private readonly IRepositorioPago _repositorioPago;

        public ServicioPago(IRepositorioPago repositorioPago)
        {
            _repositorioPago = repositorioPago;
        }

        public PagoDTO Create(CrearPagoDTO crearpagoDTO)
        {
            var pagos = _repositorioPago.Create(crearpagoDTO);
            var pagoDTO = new PagoDTO
            {
                FacturaId = pagos.FacturaId,
                Monto = pagos.Monto,
                FechaDePago = pagos.FechaDePago,
                MetodoDePago = pagos.MetodoDePago,
            };
            return pagoDTO;
        }

        public void Delete(int id)
        {
            _repositorioPago.Delete(id);
        }

        public Pago GetById(int id)
        {
            return _repositorioPago.GetById(id);
        }

        public List<PagoDTO> GetPagos()
        {
            var pagos = _repositorioPago.GetPagos();
            var pagosDTO = new List<PagoDTO>();  
            foreach (Pago pago in pagos)
            {
                var nuevosPagos = new PagoDTO
                {
                    PagoId = pago.PagoId,
                    FacturaId= pago.FacturaId,
                    Monto = pago.Monto,
                    FechaDePago= pago.FechaDePago,
                    MetodoDePago= pago.MetodoDePago,
                };
                pagosDTO.Add(nuevosPagos);
            }
            return pagosDTO;
        }

        public PagoDTO Update(int id, ActualizarPagoDTO actualizarPagoDTO)
        {
            var pagos = _repositorioPago.Update(id, actualizarPagoDTO);
            var pagosDTO = new PagoDTO
            {
                PagoId= pagos.PagoId,
                FacturaId=pagos.FacturaId,
                Monto = pagos.Monto,
                FechaDePago = pagos.FechaDePago,
                MetodoDePago = pagos.MetodoDePago,
            };
            return pagosDTO;
        }
    }
}
