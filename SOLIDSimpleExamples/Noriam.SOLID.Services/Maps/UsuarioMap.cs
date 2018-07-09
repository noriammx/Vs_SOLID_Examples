using Noriam.SOLID.Model;
using Noriam.SOLID.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noriam.SOLID.Services.Maps
{
    public class UsuarioMap : IMapToDTO<CAT_USUARIO, UsuarioDTO>
    {
        public UsuarioDTO EntityToDTO(CAT_USUARIO Entity, UsuarioDTO DTO)
        {
            throw new NotImplementedException();
        }

        public UsuarioDTO EntityToDTO(CAT_USUARIO Entity)
        {
            UsuarioDTO dto = new UsuarioDTO();
            dto.ApMaterno = Entity.AP_MATERNO;
            dto.ApPaterno = Entity.AP_PATERNO;
            dto.IdCatUsuario = Entity.ID_CAT_USUARIO;
            dto.Nombre = Entity.NOMBRE;
            dto.Usuario = Entity.USUARIO;

            return dto;
        }
    }
}
