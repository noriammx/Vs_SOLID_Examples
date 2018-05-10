using Noriam.SOLID.Model;
using Noriam.SOLID.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Attributes;

namespace Noriam.SOLID.Services.Maps
{
    public class ProductoMap : IMapToDTO<CAT_PRODUCTO, ProductoDTO>, IMapToEntity<CAT_PRODUCTO, ProductoDTO>
    {
        [Dependency]
        public PrecioMap _precioMap { private get; set; }

        public CAT_PRODUCTO DTOToEntity(CAT_PRODUCTO Entity, ProductoDTO DTO)
        {
            throw new NotImplementedException();
        }

        public CAT_PRODUCTO DTOToEntity(ProductoDTO DTO)
        {
            return new CAT_PRODUCTO()
            {
                DESCRIPCION = DTO.Nombre,
                EXISTENCIA = DTO.Existencia,
                MARCA = DTO.Marca,
                NOMBRE = DTO.Nombre,
                CREADO_POR = 1
                
            };
        }

        public ProductoDTO EntityToDTO(CAT_PRODUCTO Entity, ProductoDTO DTO)
        {
            throw new NotImplementedException();
        }

        public ProductoDTO EntityToDTO(CAT_PRODUCTO Entity)
        {
            //return AutoMapper.Mapper.Map<ProductoDTO>(Entity);
            return new ProductoDTO()
            {
                IdCatProduco = Entity.ID_CAT_PRODUCTO,
                Marca = Entity.MARCA,
                Nombre = Entity.NOMBRE,
                Existencia = Entity.EXISTENCIA.Value,
                Precio = _precioMap.EntityToDTO(Entity.CAT_PRECIO.Last()),
            };
        }
    }
}
