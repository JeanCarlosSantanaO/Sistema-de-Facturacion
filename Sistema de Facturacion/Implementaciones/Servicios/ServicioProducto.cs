using Sistema_de_Facturacion.Abstraccion.Repositorios;
using Sistema_de_Facturacion.Abstraccion.Servicios;
using Sistema_de_Facturacion.DTO.ProductoDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Implementaciones.Servicios
{
    public class ServicioProducto : IServicioProducto
    {


        private readonly IRepositorioProducto _repositorioProducto;

        public ServicioProducto(IRepositorioProducto repositorioProducto)
        {
            _repositorioProducto = repositorioProducto;
        }


        public ProductoDTO Create(CrearProductoDTO CrearproductoDTO)
        {
            var producto = _repositorioProducto.Create(CrearproductoDTO);
            var productoDTO = new ProductoDTO
            {
                Nombre=producto.Nombre,
                Descripcion=producto.Descripcion,
                PrecioUnitario=producto.PrecioUnitario,
                Impuesto=producto.Impuesto,
                FechaCreacion=producto.FechaCreacion,
            };
            return productoDTO;
        }

        public void Delete(int id)
        {
            _repositorioProducto.Delete(id);
        }

        public Producto GetById(int id)
        {
            return _repositorioProducto.GetById(id);
        }

        public List<ProductoDTO> GetProductos()
        {
            var productos = _repositorioProducto.GetProductos();
            var productoDTO = new List<ProductoDTO>();
            foreach(Producto producto in productos)
            {
                var nuevoProducto = new ProductoDTO
                {
                    ProductoId=producto.ProductoId,
                    Nombre=producto.Nombre,
                    Descripcion = producto.Descripcion,
                    PrecioUnitario = producto.PrecioUnitario,
                    Impuesto = producto.Impuesto,
                    FechaCreacion = producto.FechaCreacion,
                };
                productoDTO.Add(nuevoProducto);
            }
            return productoDTO;
        }

        public ProductoDTO Update(int id, ActualizarProductoDTO actualizarproductoDTO)
        {
            var producto =_repositorioProducto.Update(id, actualizarproductoDTO);
            var productoDTO = new ProductoDTO
            {
                Nombre = producto.Nombre,
                Descripcion=producto.Descripcion,
                PrecioUnitario=producto.PrecioUnitario,
                Impuesto=producto.Impuesto,
                FechaCreacion=producto.FechaCreacion,
            };
            return productoDTO;
        }
    }
}
