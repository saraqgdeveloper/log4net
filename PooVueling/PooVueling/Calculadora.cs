using System;

namespace PooVueling
{

    public class Calculadora : ICalculadora, ICloneable //Utilizaremos : como extends de herencia y como extens para implementar interfaces
    {
        //Esto lo hacemos para no estar referenciando a log4net en toda la aplicación
        //Con esto indicamos que servirá como punto de entrada en el archivo de configuración
        //Con esto podremos manipular el log4net, como lo utilizaremos en esta clase, lo
        //creamos directamente aquí y no en el main.
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        
        //using tiene dos funcionalidades, una para importar el namespace y otra para usar el dispose de manera implícita
        //En n.net no se pueden importar clases, sólo se pueden importar namespaces. En Java sería con *. El ámbito mínimo de compilación
        // en .Net es un proyecto.

        public object Clone()
        {
            throw new NotImplementedException("The method is not implemented yet");
        }

        public int Division(int num1, int num2)
        {
            //throw new System.NotImplementedException();
            //return num1 / num2;
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                log.Error(e.Message);
                Console.WriteLine(e.Message);
                throw;
            }

        }

        public int Multiplicacion(int num1, int num2)
        {
            //throw new System.NotImplementedException();
            return num1 * num2;
        }

        public int Resta(int num1, int num2)
        {
            //throw new System.NotImplementedException();
            return num1 - num2;
        }

        public int Suma(int num1, int num2)
        {
            //throw new System.NotImplementedException();
            return num1 + num2;
        }
    }
}
