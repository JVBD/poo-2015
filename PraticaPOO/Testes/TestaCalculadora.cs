using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PraticaPOO;

namespace Testes
{
    [TestClass]
    public class TestaCalculadora
    {
        [TestMethod]
        public void TestaSoma()
        {
            Praticas A = new Praticas();
            int resultado = A.Soma(3, 4);
            Assert.AreEqual(7,resultado);
        }
    }
}
