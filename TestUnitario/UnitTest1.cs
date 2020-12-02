using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestProductoExplicito()
        {
            Producto p1 = (Producto)"94467,Producto,19.95,6";
            Producto p2 = new Producto("94467", "Producto", 19.95, 6);

            Assert.AreEqual(p2.CodigoDeBarras, p1.CodigoDeBarras);
        }
    }
}
