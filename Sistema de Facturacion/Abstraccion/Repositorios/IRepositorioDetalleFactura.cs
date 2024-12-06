using Sistema_de_Facturacion.DTO.DetalleFacturaDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Abstraccion.Repositorios
{
    public interface IRepositorioDetalleFactura
    {
        List<DetalleFactura> GetDetalleFactura();
        DetalleFactura GetById(int id);
        DetalleFactura Create(DetalleFacturaDTO creardetalleFacturaDTO);
        DetalleFactura Update(ActualizarDetalleFacturaDTO actualizarDetalleFacturaDTO);
        void Delete(int id);
    }
}
