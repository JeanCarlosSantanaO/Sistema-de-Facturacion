using Sistema_de_Facturacion.Abstraccion.Repositorios;
using Sistema_de_Facturacion.DTO.ProductoDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Implementaciones.Repositorios
{
    public class RepositorioProducto : IRepositorioProducto
    {

        private readonly SistemaDeFacturacionContext _context;
        public RepositorioProducto(SistemaDeFacturacionContext context)
        {
            _context = context;
        }

        public Producto Create(CrearProductoDTO crearproductoDTO)
        {
            var producto = new Producto
            {
                Nombre=crearproductoDTO.Nombre,
                Descripcion=crearproductoDTO.Descripcion,
                PrecioUnitario=crearproductoDTO.PrecioUnitario,
                Impuesto=crearproductoDTO.Impuesto,
                FechaCreacion=crearproductoDTO.FechaCreacion,
            };
            _context.Productos.Add(producto);
            _context.SaveChanges();
            return producto;
            
        }

        public void Delete(int id)
        {
            Producto producto = GetById(id);
            _context.Remove(producto);
            _context.SaveChanges();
        }

        public Producto GetById(int id)
        {
            return _context.Productos.Where(p => p.ProductoId == id).FirstOrDefault();
        }

        public List<Producto> GetProductos()
        {
            return [.. _context.Productos];
        }

        public Producto Update(int id, ActualizarProductoDTO actualizarproductoDTO)
        {
            var productoExiste = GetById(id);

            productoExiste.Nombre=actualizarproductoDTO.Nombre;
            productoExiste.Descripcion=actualizarproductoDTO.Descripcion;
            productoExiste.PrecioUnitario=actualizarproductoDTO.PrecioUnitario;
            productoExiste.Impuesto=actualizarproductoDTO.Impuesto;
            productoExiste.FechaCreacion=actualizarproductoDTO.FechaCreacion;

            _context.Update(productoExiste);
            _context.SaveChanges();
            var productoActualizado = GetById(id);
            return productoActualizado;
        }
    }
}
