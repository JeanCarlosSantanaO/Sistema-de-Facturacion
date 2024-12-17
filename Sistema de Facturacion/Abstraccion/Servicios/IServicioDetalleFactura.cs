using Sistema_de_Facturacion.DTO.DetalleFacturaDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Abstraccion.Servicios
{
    public interface IServicioDetalleFactura
    {
        List<DetalleFacturaDTO> GetDetalleFactura();
        DetalleFactura GetById(int id);
        DetalleFacturaDTO Create(CrearDetalleFacturaDTO creardetalleFacturaDTO);
        DetalleFacturaDTO Update(int id,ActualizarDetalleFacturaDTO actualizardetalleFacturaDTO);
        void Delete(int id);
    }
}
