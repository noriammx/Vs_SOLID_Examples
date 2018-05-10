using Noriam.SOLID.Services.Maps;
using Noriam.SOLID.Services.Service.Contract;
using Noriam.SOLID.Services.Service.Impl;
using Noriam.SOLID.Services.UoW.Contract;
using Noriam.SOLID.Services.UoW.Impl;
using System;
using System.Collections.Generic;
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
            #endregion

            #region repositorios



            #endregion

            #region unidades de trabajo

            unityContainer.RegisterType<IGenericUnitOfWork, GenericUnitOfWork>();

            #endregion

            #region servicios

            unityContainer.RegisterType<IProductoService, ProductoService>();

            #endregion

            #region Otras dependencias


            #endregion

            return unityContainer;
        }
    }
}
