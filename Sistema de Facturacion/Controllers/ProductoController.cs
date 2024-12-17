using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Facturacion.Abstraccion.Servicios;
using Sistema_de_Facturacion.DTO.ProductoDTO;

namespace Sistema_de_Facturacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        private readonly IServicioProducto _servicioProducto;
         
        public ProductoController(IServicioProducto servicioProducto)
        {
            _servicioProducto = servicioProducto;
        }

        [HttpGet]
        public IActionResult GetProducto()
        {
            var result = _servicioProducto.GetProductos();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _servicioProducto.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(CrearProductoDTO crearProductoDTO)
        {
            var result = _servicioProducto.Create(crearProductoDTO);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id,ActualizarProductoDTO actualizarProductoDTO)
        {
            var result = _servicioProducto.Update(id, actualizarProductoDTO);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _servicioProducto.Delete(id);
            return Ok();
        }


    }
}
