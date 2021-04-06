using CalculadoraStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraStringsTest
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void SumarStringVacio()
        {
            //Arrange
            Calculadora calc = new Calculadora();

            //Act
            int suma = calc.Suma("");

            //Assert
            //1: expected
            //2: actual
            Assert.AreEqual(0, suma);
        }
        [TestMethod]
        public void SumarStringsSinComa()
        {
            //Arrange
            Calculadora calc = new Calculadora();
            //Act
            int suma = calc.Suma("1");
            //Assert
            Assert.AreEqual(1, suma);
        }
        [TestMethod]
        public void SumarStringsConComaYDosNumeros()
        {
            //Arrange
            Calculadora calc = new Calculadora();
            //Act
            int suma = calc.Suma("4,6");
            //Assert
            Assert.AreEqual(10, suma);
        }
    }
}
