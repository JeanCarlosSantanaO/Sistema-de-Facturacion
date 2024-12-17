using Sistema_de_Facturacion.DTO.FacturaDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Abstraccion.Servicios
{
    public interface IServicioFactura
    {
        List<FacturaDTO> GetFactura();
        Factura GetById(int id);
        FacturaDTO Create(CrearFacturaDTO crearfacturaDTO);
        FacturaDTO Update(int id, ActualizarFacturaDTO actualizarFacturaDTO);
        void Delete(int id);
    }
}
