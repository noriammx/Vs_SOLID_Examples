using Noriam.SOLID.Model;
using Noriam.SOLID.Services.DTO;
using Noriam.SOLID.Services.Maps;
using Noriam.SOLID.Services.Service.Contract;
using Noriam.SOLID.Services.UoW.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Attributes;

namespace Noriam.SOLID.Services.Service.Impl
{
    public class ProductoService : IProductoService
    {
        #region Dependencias

        [Dependency]
        public IGenericUnitOfWork _iGenericUnitOfWork { private get; set; }

        [Dependency]
        public ProductoMap _productoMap { private get; set; }

        [Dependency]
        public PrecioMap _precioMap { private get; set; }

        #endregion


        public void CreateProducto(ProductoDTO productoDTO)
        {
            try
            {
                var productoEntity = _productoMap.DTOToEntity(productoDTO);
                _iGenericUnitOfWork.GetRepoInstance<CAT_PRODUCTO>().Add(productoEntity);
                var precioEntity = _precioMap.DTOToEntity(productoDTO.Precio);
                _iGenericUnitOfWork.GetRepoInstance<CAT_PRECIO>().Add(precioEntity);
                _iGenericUnitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }        

        public void DeleteProducto(int IdProducto)
        {
            throw new NotImplementedException();
        }

        public List<ProductoDTO> GetAllProducts(int IdProducto)
        {
            throw new NotImplementedException();
        }

        public ProductoDTO GetProduct(int IdProducto)
        {
            try
            {
                var productoEntity = _iGenericUnitOfWork.GetRepoInstance<CAT_PRODUCTO>().Find(p => p.ID_CAT_PRODUCTO == IdProducto).First();
                var productoDTO = _productoMap.EntityToDTO(productoEntity);

                return productoDTO;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void UpdateProducto(ProductoDTO productoDTO)
        {
            throw new NotImplementedException();
        }
    }
}
