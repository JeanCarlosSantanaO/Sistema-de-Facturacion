using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Facturacion.Abstraccion.Servicios;
using Sistema_de_Facturacion.DTO.FacturaDTO;

namespace Sistema_de_Facturacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly IServicioFactura _servicioFactura;

        public FacturaController(IServicioFactura servicioFactura)
        {
            _servicioFactura = servicioFactura;
        }

        [HttpGet]
        public IActionResult GetFactura()
        {
            var result = _servicioFactura.GetFactura();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _servicioFactura.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(CrearFacturaDTO crearFacturaDTO)
        {
            var result = _servicioFactura.Create(crearFacturaDTO);
            return Ok(result);  
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id,ActualizarFacturaDTO actualizarFacturaDTO)
        {
            var result = _servicioFactura.Update(id, actualizarFacturaDTO);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _servicioFactura.Delete(id);
            return Ok();
        }
    }
}
