using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Facturacion.Abstraccion.Servicios;
using Sistema_de_Facturacion.DTO.ClienteDTO;
using Sistema_de_Facturacion.DTO.PagoDTO;

namespace Sistema_de_Facturacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagoController : ControllerBase
    {

        private readonly IServicioPago _servicioPago;

        public PagoController(IServicioPago servicioPago)
        {
            _servicioPago = servicioPago;
        }

        [HttpGet]
        public IActionResult GetPagos()
        {
            var result = _servicioPago.GetPagos();
            return Ok(result);  
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _servicioPago.GetById(id);
            return Ok(result);

        }

        [HttpPost]
        public IActionResult Create(CrearPagoDTO crearPagoDTO)
        {
            var result = _servicioPago.Create(crearPagoDTO);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id,ActualizarPagoDTO actualizarPagoDTO)
        {
            var result = _servicioPago.Update(id, actualizarPagoDTO);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _servicioPago.Delete(id);
            return Ok();
        }
    }
}
