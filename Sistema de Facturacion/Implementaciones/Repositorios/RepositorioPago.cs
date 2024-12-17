using Sistema_de_Facturacion.Abstraccion.Repositorios;
using Sistema_de_Facturacion.DTO.PagoDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Implementaciones.Repositorios
{

    public class RepositorioPago : IRepositorioPago
    {


        private readonly SistemaDeFacturacionContext _context;

        public RepositorioPago(SistemaDeFacturacionContext context)
        {
            _context = context;
        }

        public Pago Create(CrearPagoDTO crearpagoDTO)
        {
            var pagos = new Pago
            {
                FacturaId=crearpagoDTO.FacturaId,
                Monto = crearpagoDTO.Monto,
                FechaDePago =crearpagoDTO.FechaDePago,
                MetodoDePago=crearpagoDTO.MetodoDePago,
            };
            _context.Pagos.Add(pagos);
            _context.SaveChanges();
            return pagos;
        }

        public void Delete(int id)
        {
            Pago pago =GetById(id);
            _context.Remove(pago);
            _context.SaveChanges();
        }

        public Pago GetById(int id)
        {
            return _context.Pagos.Where(p => p.PagoId == id).FirstOrDefault();
        }

        public List<Pago> GetPagos()
        {
            return [.. _context.Pagos];
        }

        public Pago Update(int id, ActualizarPagoDTO actualizarPagoDTO)
        {
            var pagoExiste = GetById(id);

            pagoExiste.FacturaId=actualizarPagoDTO.FacturaId;
            pagoExiste.Monto = actualizarPagoDTO.Monto;
            pagoExiste.FechaDePago=actualizarPagoDTO.FechaDePago;
            pagoExiste.MetodoDePago = actualizarPagoDTO.MetodoDePago;

            _context.Update(pagoExiste);
            _context.SaveChanges();
            var pagoActualizado =GetById(id);
            return pagoActualizado;
        }
    }
}
