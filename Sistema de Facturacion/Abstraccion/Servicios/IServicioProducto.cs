using Sistema_de_Facturacion.DTO.ProductoDTO;
using Sistema_de_Facturacion.Modelos;

namespace Sistema_de_Facturacion.Abstraccion.Servicios
{
    public interface IServicioProducto
    {
        List<ProductoDTO> GetProductos();
        Producto GetById(int id);
        ProductoDTO Create(CrearProductoDTO CrearproductoDTO);
        ProductoDTO Update(int id,ActualizarProductoDTO actualizarproductoDTO);
        void Delete(int id);
    }
}
