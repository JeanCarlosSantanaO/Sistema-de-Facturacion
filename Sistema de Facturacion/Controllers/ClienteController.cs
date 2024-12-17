using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Facturacion.Abstraccion.Servicios;
using Sistema_de_Facturacion.DTO.ClienteDTO;
using Sistema_de_Facturacion.Implementaciones.Repositorios;


namespace Sistema_de_Facturacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IServicioCliente _servicioCliente;

        public ClienteController(IServicioCliente servicio)
        {
            _servicioCliente = servicio;
        }


        [HttpGet]
        public IActionResult GetCliente() 
        { 
            
            var result = _servicioCliente.GetClienteDTO();
            return Ok(result);
            
        }

        [HttpPost]
         public IActionResult Create(CrearClienteDTO crearClienteDTO)
         {
            var result = _servicioCliente.Create(crearClienteDTO );
            return Ok(result);
         } 
        [HttpPut("{id}")]
        public IActionResult Update(int id,ActualizarClienteDTO actualizarClienteDTO)
        {
            var result = _servicioCliente.Update(id, actualizarClienteDTO);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _servicioCliente.GetById(id);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            _servicioCliente.Delete(id);
            return Ok();
        }

    }
}
