using Noriam.SOLID.Model;
using Noriam.SOLID.Services.DTO;
using Noriam.SOLID.Services.Maps;
using Noriam.SOLID.Services.Repository.Contract;
using Noriam.SOLID.Services.Repository.Impl;
using Noriam.SOLID.Services.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Attributes;

namespace Noriam.SOLID.Services.Service.Impl
{
    public class UsuarioService : IUsuarioService
    {


        private  IGenericRepository<CAT_USUARIO> _iGenericRepository;


        private UsuarioMap _usuarioMap;

        public UsuarioService()
        {
            _iGenericRepository = new GenericRepository<CAT_USUARIO>(new ABC_SOLIDEntities());
            _usuarioMap = new Maps.UsuarioMap();
        }

        public UsuarioDTO AutenticarUsuario(string usuario, string contrasenia)
        {
            var user = _iGenericRepository.Find(p => p.USUARIO == usuario && p.CONTRASENIA == contrasenia).First();

            return _usuarioMap.EntityToDTO(user);

        }

        public List<RolDTO> GetRoles()
        {
            throw new NotImplementedException();
        }
    }
}
