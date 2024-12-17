using Sistema_de_Facturacion.DTO.DetalleFacturaDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Abstraccion.Repositorios
{
    public interface IRepositorioDetalleFactura
    {
        List<DetalleFactura> GetDetalleFactura();
        DetalleFactura GetById(int id);
        DetalleFactura Create(CrearDetalleFacturaDTO creardetalleFacturaDTO);
        DetalleFactura Update(int id,ActualizarDetalleFacturaDTO actualizarDetalleFacturaDTO);
        void Delete(int id);
    }
}
