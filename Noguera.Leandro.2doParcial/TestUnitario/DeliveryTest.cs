using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Archivo;
using Entidades;
using Excepciones;

namespace TestUnitario
{
    [TestClass]
    public class DeliveryTest
    {
        /// <summary>
        /// Verifica que se lance ArchivosException al pasarle una cadena erronea a EjercutarNonQuery
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void Test_EjecutarNonQuery()
        {
            string sql = "hola";
            bool retorno;

            retorno = ManejadorSQL.EjecutarNonQuery(sql);
        }

        /// <summary>
        /// Verifica que el metodo guardar de inventario, devuelva true al serializar los datos.
        /// </summary>
        [TestMethod]
        public void Test_InventarioGuardar()
        {
            bool retorno = Inventario.Guardar();

            Assert.IsTrue(retorno);
        }
    }
}
