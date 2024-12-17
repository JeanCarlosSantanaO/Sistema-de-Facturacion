using Sistema_de_Facturacion.Abstraccion.Repositorios;
using Sistema_de_Facturacion.DTO.FacturaDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Implementaciones.Repositorios
{
    public class RepositorioFactura : IRepositorioFactura
    {

        private readonly SistemaDeFacturacionContext _context;

        public RepositorioFactura(SistemaDeFacturacionContext context)
        {
            _context = context;
        }

        public Factura Create(CrearFacturaDTO crearfacturaDTO)
        {
            var factura = new Factura
            {
                ClienteId=crearfacturaDTO.ClienteId,
                NumeroFactura=crearfacturaDTO.NumeroFactura,
                FechaEmision=crearfacturaDTO.FechaEmision,
                TotalBruto=crearfacturaDTO.TotalBruto,
                ImpuestoTotal=crearfacturaDTO.ImpuestoTotal,
                TotalNeto=crearfacturaDTO.TotalNeto,
                Estado=crearfacturaDTO.Estado,
                
            };
            _context.Facturas.Add(factura);
            _context.SaveChanges();
            return factura;
        }

        public void Delete(int id)
        {     
            Factura factura = GetById(id);
            _context.Remove(factura);
            _context.SaveChanges();
            
        }

        public Factura GetById(int id)
        {
            return _context.Facturas.Where(f => f.FacturaId == id).FirstOrDefault();
        }

        public List<Factura> GetFacturas()
        {
            return [.._context.Facturas];
        }

        public Factura Update(int id, ActualizarFacturaDTO actualizarfacturaDTO)
        {
            var facturaExiste =GetById(id);

            facturaExiste.ClienteId=actualizarfacturaDTO.ClienteId;
            facturaExiste.NumeroFactura=actualizarfacturaDTO.NumeroFactura;
            facturaExiste.FechaEmision=actualizarfacturaDTO.FechaEmision;
            facturaExiste.TotalBruto=actualizarfacturaDTO.TotalBruto;
            facturaExiste.ImpuestoTotal=actualizarfacturaDTO .ImpuestoTotal; 
            facturaExiste.TotalNeto = actualizarfacturaDTO.TotalNeto;
            facturaExiste.Estado=actualizarfacturaDTO .Estado;

            _context.Update(facturaExiste);
            _context.SaveChanges();
            var facturaActualizada = GetById(id);
            return facturaActualizada;

        }
    }
}
