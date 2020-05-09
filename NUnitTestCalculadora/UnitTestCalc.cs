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
            int suma = Calculadora.suma(a,b);
            //Asser
            Assert.AreEqual(resultado, suma);
            Assert.Pass();
        }
    }
}