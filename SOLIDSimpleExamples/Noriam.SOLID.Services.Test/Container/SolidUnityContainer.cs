using Noriam.SOLID.Model;
using Noriam.SOLID.Services.Maps;
using Noriam.SOLID.Services.Repository.Contract;
using Noriam.SOLID.Services.Repository.Impl;
using Noriam.SOLID.Services.Service.Contract;
using Noriam.SOLID.Services.Service.Impl;
using Noriam.SOLID.Services.UoW.Contract;
using Noriam.SOLID.Services.UoW.Impl;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Noriam.SOLID.Services.Test.Container
{
    public static class SolidUnityContainer
    {
        public static UnityContainer CreateGeconUnityContainer()
        {
            var unityContainer = new UnityContainer();

            #region mapeos

            unityContainer.RegisterType<ProductoMap, ProductoMap>();
            unityContainer.RegisterType<PrecioMap, PrecioMap>();
            unityContainer.RegisterType<UsuarioMap, UsuarioMap>();
            #endregion

            #region repositorios

            unityContainer.RegisterType<IGenericRepository<CAT_USUARIO>, GenericRepository<CAT_USUARIO>>();

            #endregion

            #region unidades de trabajo

            unityContainer.RegisterType<IGenericUnitOfWork, GenericUnitOfWork>();

            #endregion

            #region servicios

            unityContainer.RegisterType<IProductoService, ProductoService>();
            unityContainer.RegisterType<IUsuarioService, UsuarioService>();

            #endregion

            #region Otras dependencias
            unityContainer.RegisterType<DbContext, ABC_SOLIDEntities>();
            

            #endregion

            return unityContainer;
        }
    }
}
