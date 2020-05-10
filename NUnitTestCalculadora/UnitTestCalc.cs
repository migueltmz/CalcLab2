using NUnit.Framework;
using NUnit.Framework.Constraints;
using calculadora;

namespace NUnitTestCalculadora
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSuma([Values(1,-3,10000)] int sumando)
        {
            //Arrange
            int b = 4;
            int resultado = sumando + b;
            //Act
            int r = Calculadora.suma(sumando,b);
            //Assert
            Assert.AreEqual(resultado, r);
        }

        [Test]
        public void TestResta()
        {
            //Arrange
            int a = 1;
            int b = 4;
            int resultado = -3;
            //Act
            int r = Calculadora.resta(a, b);
            //Assert
            Assert.AreEqual(resultado, r);
        }

        [Test]
        public void TestDivision()
        {
            //Arrange
            int a = 4;
            int b = 2;
            int resultado = 2;
            //Act
            double r = Calculadora.division(a, b);
            //Assert
            Assert.AreEqual(resultado, r);
        }

        [Test]
        public void TestDivisionCero()
        {
            //Arrange
            int a = 4;
            int b = 0;
            //Act
            double r = Calculadora.division(a, b);
            //Assert
            Assert.AreEqual(double.PositiveInfinity, r);
        }

        [Test]
        public void TestDivisionCeroNeg()
        {
            //Arrange
            int a = -4;
            int b = 0;
            //Act
            double r = Calculadora.division(a, b);
            //Assert
            Assert.AreEqual(double.NegativeInfinity, r);
        }

        [Test]
        public void TestMultiplicacion()
        {
            //Arrange
            int a = 4;
            int b = 2;
            int resultado = 8;
            //Act
            int r = Calculadora.multiplicacion(a, b);
            //Assert
            Assert.AreEqual(resultado, r);
        }

        [Test]
        public void TestRaizCuadradaPositivos()
        {
            //Arrange
            int a = 7;
            double resultado = 2.64575131106;
            //Act
            double r = Calculadora.raiz(a);
            //Assert
            Assert.AreEqual(resultado, r, 0.00001); //una de las sobrecargas del método AreEqual incluye como tercer parámetro un delta que es la precisión
        }

        [Test]
        public void TestRaizCuadradaNegativos()
        {
            //Arrange
            int a = -7;
            //Act
            double r = Calculadora.raiz(a);
            //Assert
            Assert.AreEqual(double.NaN,r);
        }

        [Test]
        public void TestDemuestraAssertconDelta()
        {
            //Arrange
            double resultado = 2.64575131106;
            //Act
            double r = 2.645759;
            //Assert
            Assert.AreEqual(resultado, r, 0.00001); //una de las sobrecargas del método AreEqual incluye como tercer parámetro un delta que es la precisión
        }
    }
}