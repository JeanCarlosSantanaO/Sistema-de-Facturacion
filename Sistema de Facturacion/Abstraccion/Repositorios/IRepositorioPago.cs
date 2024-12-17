using Sistema_de_Facturacion.DTO.PagoDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Abstraccion.Repositorios
{
    public interface IRepositorioPago
    {
        List<Pago> GetPagos();
        Pago GetById(int id);
        Pago Create(CrearPagoDTO crearpagoDTO);
        Pago Update(int id,ActualizarPagoDTO actualizarPagoDTO);
        void Delete(int id);
    }
}
