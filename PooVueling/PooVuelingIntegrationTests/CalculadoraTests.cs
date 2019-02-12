using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        ICalculadora iCalculadora = new Calculadora();

        [DataRow(4,2,2)]
        [DataRow(9, 3, 3)]
        [DataRow(9, 1, 9)]
        [DataRow(9, 0, 0)] //Este dará error, porque no se puede dividir entre 0
        [DataTestMethod]

        public void DivisionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1, num2) == resultado);
        }

        [DataRow(9, 0, 0)] //Este daría error, porque no se puede dividir entre 0
        [DataTestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionDivideByZeroExceptionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1, num2) == resultado);
        }


        [DataRow(4, 2, 8)]
        [DataRow(6, 3, 18)]
        [DataTestMethod]

        [TestMethod()]
        public void MultiplicacionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Multiplicacion(num1, num2) == resultado);
        }
        [DataRow(4, 2, 2)]
        [DataRow(6, 3, 3)]
        [DataTestMethod]

        [TestMethod()]
        public void RestaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Resta(num1, num2) == resultado);
        }
        [DataRow(4, 2, 6)]
        [DataRow(6, 3, 9)]
        [DataTestMethod]

        [TestMethod()]
        public void SumaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Suma(num1, num2) == resultado);
        }

    }
}