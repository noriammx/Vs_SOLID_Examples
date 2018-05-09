using Noriam.SOLID.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noriam.SOLID.Services.Service.Contract
{
    public interface IUsuarioService
    {
        UsuarioDTO AutenticarUsuario(string usuario, string contrasenia);

        List<RolDTO> GetRoles();
    }
}
