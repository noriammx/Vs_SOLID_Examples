using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;
using Noriam.SOLID.Services.Test.Container;
using Noriam.SOLID.Services.Service.Impl;
using Noriam.SOLID.Services.DTO;

namespace Noriam.SOLID.Services.Test.Test
{
    /// <summary>
    /// Descripción resumida de ProductoServiceTest
    /// </summary>
    [TestClass]
    public class ProductoServiceTest
    {

        UnityContainer _unityContainer;

        public ProductoServiceTest()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //

            _unityContainer = SolidUnityContainer.CreateGeconUnityContainer();
           // SolidMapperConfig.InitializeAutomapper();
        }

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

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GetProductTest()
        {
            //
            // TODO: Agregar aquí la lógica de las pruebas
            //

            var service = _unityContainer.Resolve<ProductoService>();

            //service.GetProduct(3);
        }

        [TestMethod]
        public void CreateProductTest()
        {
            //
            // TODO: Agregar aquí la lógica de las pruebas
            //

            var service = _unityContainer.Resolve<ProductoService>();

            var producto = new ProductoDTO
            {
                Existencia = 10,
                Marca = "Marino",
                Nombre = "Playera Polo"
            };

            var precio = new PrecioDTO
            {
                Activo = true,
                FechaInicio = DateTime.Now,
                PrecioCompra = 2356,
                PrecioVenta = 6355
            };

            producto.Precio = precio;

            service.CreateProducto(producto);

        }
    }
}
