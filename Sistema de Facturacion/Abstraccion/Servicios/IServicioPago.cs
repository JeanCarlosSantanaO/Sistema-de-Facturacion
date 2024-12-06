using Sistema_de_Facturacion.DTO.PagoDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Abstraccion.Servicios
{
    public interface IServicioPago
    {
        List<PagoDTO> GetPagos();
        Pago GetById(int id);
        PagoDTO Create(PagoDTO crearpagoDTO);
        PagoDTO Update(PagoDTO actualizarPagoDTO);
        void Delete(int id);
    }
}
