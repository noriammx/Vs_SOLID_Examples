using Noriam.SOLID.Model;
using Noriam.SOLID.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noriam.SOLID.Services.Maps
{
    public class PrecioMap : IMapToDTO<CAT_PRECIO, PrecioDTO>, IMapToEntity<CAT_PRECIO, PrecioDTO>
    {
        public CAT_PRECIO DTOToEntity(CAT_PRECIO Entity, PrecioDTO DTO)
        {
            throw new NotImplementedException();
        }

        public CAT_PRECIO DTOToEntity(PrecioDTO DTO)
        {
            return new CAT_PRECIO()
            {
                CREADO_POR = 1,
                ACTIVO = true,
                FECHA_INICIO = DateTime.Now,
                PRECIO_COMPRA = DTO.PrecioCompra,
                PRECIO_VENTA = DTO.PrecioVenta
            };
        }

        public PrecioDTO EntityToDTO(CAT_PRECIO Entity, PrecioDTO DTO)
        {
            throw new NotImplementedException();
        }

        public PrecioDTO EntityToDTO(CAT_PRECIO Entity)
        {
            return new PrecioDTO()
            {
                Activo = Entity.ACTIVO.HasValue ? Entity.ACTIVO.Value : false,
                FechaFin = Entity.FECHA_FIN.Value,
                FechaInicio = Entity.FECHA_INICIO,
                IdCatPrecio = Entity.ID_CAT_PRECIO,
                PrecioCompra = Entity.PRECIO_COMPRA.Value,
                PrecioVenta = Entity.PRECIO_VENTA.Value
                
            };
        }
    }
}
