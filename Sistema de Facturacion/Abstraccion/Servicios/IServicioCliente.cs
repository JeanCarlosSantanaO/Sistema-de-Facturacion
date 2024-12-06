using Sistema_de_Facturacion.DTO.ClienteDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Abstraccion.Servicios
{
    public interface IServicioCliente
    {
        List<ClienteDTO> GetClienteDTO();
        Cliente GetById(int id);
        ClienteDTO Create(ClienteDTO createclienteDTO);
        ClienteDTO Update(ClienteDTO ActualizarclienteDTO);
        void Delete(int id);
    }
}
