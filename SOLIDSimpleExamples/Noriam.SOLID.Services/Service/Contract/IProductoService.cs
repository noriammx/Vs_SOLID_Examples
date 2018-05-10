using Noriam.SOLID.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noriam.SOLID.Services.Service.Contract
{
    public interface IProductoService
    {

        void CreateProducto(ProductoDTO productoDTO);

        void UpdateProducto(ProductoDTO productoDTO);

        void DeleteProducto(int IdProducto);

        ProductoDTO GetProduct(int IdProducto);

        List<ProductoDTO> GetAllProducts(int IdProducto);


    }
}
