using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using poo__paint;


namespace TesteRetangulo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testa_Retangulo()
        {
            Retangulo r1 = new Retangulo(10, 20, 50, 60);
            Assert.AreEqual("retangulo[x:10,y:20,l:50,a:60]", r1.Imprime());
            Retangulo r2 = new Retangulo(5, 5, 10, 200);
            Assert.AreEqual("retangulo[x:5,y:5,l:10,a:200]", r2.Imprime());
        }

        public void Testa_Contador()
        {
            //Retangulo.ZeraContador(); Assert.AreEqual(0, Retangulo.LeContador());
            //Retangulo r1 = new Retangulo(10, 20, 50, 60); Retangulo r2 = new Retangulo(5, 5, 10, 200); Assert.AreEqual(2, Retangulo.LeContador());
            //Retangulo r3 = new Retangulo(5, 5, 3, 67); Assert.AreEqual(3, Retangulo.LeContador());
        }

    }

}
