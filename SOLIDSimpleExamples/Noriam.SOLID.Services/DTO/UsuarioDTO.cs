using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noriam.SOLID.Services.DTO
{
    public class UsuarioDTO
    {
        public int IdCatUsuario { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }
        public RolDTO Rol { get; set; }
    }
}
