using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Facturacion.Abstraccion.Servicios;
using Sistema_de_Facturacion.DTO.DetalleFacturaDTO;

namespace Sistema_de_Facturacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleFacturaController : ControllerBase
    {
        private readonly IServicioDetalleFactura _servicioDetalleFactura;

        public DetalleFacturaController(IServicioDetalleFactura servicioDetalleFactura)
        {
            _servicioDetalleFactura = servicioDetalleFactura;
        }

        [HttpGet]
        public IActionResult GetDetalleFactura()
        {
            var result = _servicioDetalleFactura.GetDetalleFactura();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(CrearDetalleFacturaDTO crearDetalleFacturaDTO)
        {
            var result = _servicioDetalleFactura.Create(crearDetalleFacturaDTO);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id,ActualizarDetalleFacturaDTO actualizarDetalleFacturaDTO)
        {
            var result = _servicioDetalleFactura.Update(id, actualizarDetalleFacturaDTO); 
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _servicioDetalleFactura.GetById(id);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _servicioDetalleFactura.Delete(id);
            return Ok();
        }
    }
}
