using Sistema_de_Facturacion.DTO.FacturaDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Abstraccion.Repositorios
{
    public interface IRepositorioFactura
    {
        List<Factura> GetFacturas();
        Factura GetById(int id);
        Factura Create(CrearFacturaDTO crearfacturaDTO);
        Factura Update(int id,ActualizarFacturaDTO actualizarfacturaDTO);
        void Delete(int id);
    }
}
