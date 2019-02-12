using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    class Program
    {
        

        static void Main(string[] args)
        { ICalculadora iCalculadora = new Calculadora();
            iCalculadora.Suma(5, 5);
            iCalculadora.Resta(8, 3);
            iCalculadora.Multiplicacion(2, 5);
            iCalculadora.Division(4, 0);           
        }
    }
}
