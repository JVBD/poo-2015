using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using poo__paint;

namespace poo__paint    
{
    [TestClass]
    public class TesteContador
    {
        [TestMethod]
        public void TestaContador()
        {
            Retangulo r1 = new Retangulo(10, 20, 50, 60);
            Assert.AreEqual(1, Retangulo.LeContador());
            Retangulo r2 = new Retangulo(5, 5, 10, 200);
            Assert.AreEqual(2, Retangulo.LeContador());
            Retangulo r3 = new Retangulo(5, 5, 3, 67);
            Assert.AreEqual(3, Retangulo.LeContador());
        }
    }
}
