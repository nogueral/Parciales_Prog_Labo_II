using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Comercio;
using System.Collections.Generic;

namespace TestUnitario
{
    [TestClass]
    public class TestUnitario
    {
        [TestMethod]
        public void Test_ValidarString()
        {
            string auxString = "hola";


            bool retorno = Validar.ValidarString(auxString);

            Assert.IsFalse(retorno);

        }

        [TestMethod]
        public void Test_ValidarClienteSimpson()
        {
            Cliente auxCliente = new Cliente("Homero", "Simpson", 123456);

            bool retorno = Inventario.ValidarCliente(auxCliente);

            Assert.IsTrue(retorno);

        }

        [TestMethod]
        public void Test_AgregarProducto()
        {

            ProductoPerecedero auxProducto = new ProductoPerecedero("leche descremada", 111, 78, 48, Producto.ETipo.perecedero);

            Inventario.ListaProductos.Add(auxProducto);

            Assert.IsTrue(Inventario.ListaProductos == auxProducto);

        }

        [TestMethod]
        public void Test_GetListaEmpleados()
        {
            List<Empleado> auxListaEmpleados = Inventario.GetListaEmpleados();



            Assert.IsFalse(auxListaEmpleados.Count > 0);

        }
    }
}
