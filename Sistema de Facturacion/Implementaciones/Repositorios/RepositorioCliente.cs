using Sistema_de_Facturacion.Abstraccion.Repositorios;
using Sistema_de_Facturacion.DTO.ClienteDTO;
using Sistema_de_Facturacion.Modelos;
using System.Reflection.Metadata.Ecma335;

namespace Sistema_de_Facturacion.Implementaciones.Repositorios
{
    public class RepositorioCliente : IRepositorioCliente
    {

        private readonly SistemaDeFacturacionContext _context;

        public RepositorioCliente(SistemaDeFacturacionContext context)
        {
           _context = context;
        }


        public Cliente GetById(int id)
        {

            return _context.Clientes.Where(c => c.ClienteId == id).FirstOrDefault();

        }

        public Cliente Create(CrearClienteDTO crearClienteDTO)
        {
            var cliente = new Cliente
            {
                Nombre = crearClienteDTO.Nombre,
                Apellido = crearClienteDTO.Apellido,
                Direccion = crearClienteDTO.Direccion,
                Telefono = crearClienteDTO.Telefono,
                Correo = crearClienteDTO.Correo,
                IdentificacionFiscal = crearClienteDTO.IdentificacionFiscal,
            };
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return cliente;
        }

      

        public void Delete(int id)
        {
            Cliente cliente = GetById(id);
            _context.Remove(cliente);
            _context.SaveChanges();
        }

        public List<Cliente> GetCliente()
        {

            return [.. _context.Clientes];
        }

        public Cliente Update(int id,ActualizarClienteDTO actualizarClienteDTO)
        {
            var clienteExiste = GetById(id);

            clienteExiste.Nombre = actualizarClienteDTO.Nombre ?? clienteExiste.Nombre;
            clienteExiste.Apellido = actualizarClienteDTO.Apellido ?? clienteExiste.Apellido;
            clienteExiste.Direccion = actualizarClienteDTO.Direccion ?? clienteExiste.Direccion;
            clienteExiste.Telefono = actualizarClienteDTO.Telefono ?? clienteExiste.Telefono;
            clienteExiste.Correo = actualizarClienteDTO.Correo ?? clienteExiste.Correo;
            clienteExiste.IdentificacionFiscal = actualizarClienteDTO.IdentificacionFiscal ?? clienteExiste.IdentificacionFiscal;


            _context.Update(clienteExiste);
            _context.SaveChanges();
            var clienteActualizado = GetById(id);
            return clienteActualizado;
        }

        
    }
}
