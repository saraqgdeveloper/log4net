using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PooVueling;//Teniendo esto ya puedo instanciar poovueling
using NUnit.Framework;//Se utiliza para poder acceder a los customs atributes de c#


namespace PooVueling.NunitV.Integration.Tests
{
    
   [TestFixture]//Para verlo necesitamos importar el paquete NuniT.framework

    public class CalculadoraTest
    {
        ICalculadora iCalculadora = new Calculadora();

        [TestCase(3,2,5)]
        public void SumarTest(int num1, int num2, int resultado)

        {
            Assert.AreEqual(iCalculadora.Suma(num1, num2), resultado);

        }

        
        [TestCase(10, 4, 6)]
        public void RestarTest(int num1, int num2, int resultado)

        {
            Assert.AreEqual(iCalculadora.Resta(num1, num2), resultado);

        }


        [TestCase(2, 5, 10)]
        public void MultiplicarTest(int num1, int num2, int resultado)

        {
            Assert.AreEqual(iCalculadora.Multiplicacion(num1, num2), resultado);

        }


        [TestCase(10, 5, 2)]
        public void DividirTest(int num1, int num2, int resultado)

        {
            Assert.AreEqual(iCalculadora.Division(num1, num2), resultado);

        }
    }
}
