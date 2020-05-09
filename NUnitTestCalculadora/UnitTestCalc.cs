using NUnit.Framework;

namespace NUnitTestCalculadora
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSumaPositivos()
        {
            //Arrange
            int a = 1;
            int b = 4;
            int resultado = 5;
            //Act
            int r = Calculadora.suma(a,b);
            //Asser
            Assert.AreEqual(resultado, r);
        }

        [Test]
        public void TestRestaPositivos()
        {
            //Arrange
            int a = 1;
            int b = 4;
            int resultado = -3;
            //Act
            int r = Calculadora.resta(a, b);
            //Asser
            Assert.AreEqual(resultado, r);
        }

        [Test]
        public void TestDivisionPositivos()
        {
            //Arrange
            int a = 4;
            int b = 2;
            int resultado = 2;
            //Act
            int r = Calculadora.division(a, b);
            //Asser
            Assert.AreEqual(resultado, r);
        }

        [Test]
        public void TestMultiplicacionPositivos()
        {
            //Arrange
            int a = 4;
            int b = 2;
            int resultado = 8;
            //Act
            int r = Calculadora.multiplicacion(a, b);
            //Asser
            Assert.AreEqual(resultado, r);
        }
    }
}