using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConvert1()
        {
            string a = "I";
            var clase = new Class1();
            int resultado = clase.convertir(a);
            Assert.IsTrue(resultado.Equals(1));
        }
        [TestMethod]
        public void TestConvert2()
        {
            string a = "II";
            var clase = new Class1();
            int resultado = clase.convertir(a);
            Assert.IsTrue(resultado.Equals(2));
        }
        [TestMethod]
        public void TestConvert3()
        {
            string a = "III";
            var clase = new Class1();
            int resultado = clase.convertir(a);
            Assert.IsTrue(resultado.Equals(3));
        }
        [TestMethod]
        public void TestConvert4()
        {
            string a = "IV";
            var clase = new Class1();
            int resultado = clase.convertir(a);
            Assert.IsTrue(resultado.Equals(4));
        }
        [TestMethod]
        public void TestConvert5()
        {
            string a = "CM";
            var clase = new Class1();
            int resultado = clase.convertir(a);
            Assert.IsTrue(resultado.Equals(900));
        }
        [TestMethod]
        public void TestConvert6()
        {
            string a = "(fgdgd){}";
            var clase = new Class1();
            bool resultado = clase.validar(a);
            Assert.IsTrue(resultado);
        }
        

  }
}
