using Sistema_de_Facturacion.DTO.ProductoDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Abstraccion.Repositorios
{
    public interface IRepositorioProducto
    {
        List<Producto> GetProductos();
        Producto GetById(int id);
        Producto Create(CrearProductoDTO crearproductoDTO);
        Producto Update(int id,ActualizarProductoDTO actualizarproductoDTO);
        void Delete(int id);
    }
}
