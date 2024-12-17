using Sistema_de_Facturacion.Abstraccion.Repositorios;
using Sistema_de_Facturacion.Abstraccion.Servicios;
using Sistema_de_Facturacion.DTO.ClienteDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Implementaciones.Servicios
{
    public class ServicioCliente : IServicioCliente
    {
        private readonly IRepositorioCliente repositorioCliente;

        public ServicioCliente(IRepositorioCliente repositorio)
        {
            repositorioCliente = repositorio;
        }


        public ClienteDTO Create(CrearClienteDTO createclienteDTO)
        {
            var cliente = repositorioCliente.Create(createclienteDTO);
            var clienteDTO = new ClienteDTO
            {

                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Correo = cliente.Correo,
                Telefono = cliente.Telefono,
                Direccion = cliente.Direccion,
                IdentificacionFiscal = cliente.IdentificacionFiscal,

            };
            return clienteDTO;
        }

        public void Delete(int id)
        {
            repositorioCliente.Delete(id);
        }

        public Cliente GetById(int id)
        {
          return  repositorioCliente.GetById(id);
        }

        public List<ClienteDTO> GetClienteDTO()
        {
            var clientes = repositorioCliente.GetCliente();
            var clienteDTO = new List<ClienteDTO>();
            foreach(Cliente  cliente in clientes)
            {
                var nuevoclienteDTO = new ClienteDTO
                {
                    ClienteId = cliente.ClienteId,
                    Nombre = cliente.Nombre,
                    Apellido= cliente.Apellido,
                    Correo = cliente.Correo,
                    Telefono= cliente.Telefono,
                    Direccion= cliente.Direccion,
                    IdentificacionFiscal = cliente.IdentificacionFiscal,
                    FechaDeRegistro = cliente.FechaDeRegistro,
                };
                clienteDTO.Add(nuevoclienteDTO);

            }
            return clienteDTO;
        }

        public ClienteDTO Update(int id,ActualizarClienteDTO ActualizarclienteDTO)
        {
            var cliente = repositorioCliente.Update(id, ActualizarclienteDTO);
            var clienteDTO = new ClienteDTO
            {
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido,
                Correo = cliente.Correo,
                Telefono = cliente.Telefono,
                Direccion = cliente.Direccion,
                IdentificacionFiscal = cliente.IdentificacionFiscal,
            };
            return clienteDTO;
        }
    }
}
