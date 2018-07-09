using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Noriam.SOLID.Model;
using Noriam.SOLID.Services.Repository.Impl;
using Noriam.SOLID.Services.Service.Impl;
using Noriam.SOLID.Services.Test.Container;
using Unity;

namespace Noriam.SOLID.Services.Test.Test
{
    [TestClass]
    public class UsuarioServiceTest
    {
        UnityContainer _unityContainer;

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        public UsuarioServiceTest()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //

            _unityContainer = SolidUnityContainer.CreateGeconUnityContainer();
            // SolidMapperConfig.InitializeAutomapper();
        }


        [TestMethod]
        public void GetUsuarioTest()
        {

            //var service = _unityContainer.Resolve<UsuarioService>();
            //var service = new UsuarioService(new GenericRepository<CAT_USUARIO>(new ABC_SOLIDEntities()), new Maps.UsuarioMap());

            var service = new UsuarioService();

            var user = service.AutenticarUsuario("lmartinez", "Corepro1");

        }
    }
}
