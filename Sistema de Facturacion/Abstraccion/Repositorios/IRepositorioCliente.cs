using Sistema_de_Facturacion.DTO.ClienteDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Abstraccion.Repositorios
{
    public interface IRepositorioCliente
    {
        List<Cliente> GetCliente();
        Cliente GetById(int id);
        Cliente Create(CrearClienteDTO crearClienteDTO);
        Cliente Update(ActualizarClienteDTO actualizarClienteDTO);
        void Delete(int id);
    }
}
