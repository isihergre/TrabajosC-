using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos de datos
            //investigar la especificacion de formatos
            int i = 0;
            decimal x = 0.0m;
            float f = 0.0f;
            double d = 0.00d;
            string cadena = "Hola Mundo";
            bool bandera = false;
            DateTime fecha = DateTime.MinValue;
            Console.WriteLine("El valor de i es: {0}", i);
            Console.WriteLine("El valor de x es: {0:c}", x);
            Console.WriteLine("El valor de f es: {0:F2}",f);
            Console.WriteLine("El valor de d es:{0:F2}", d);
            Console.WriteLine("El valor de cadena es: " + cadena);
            Console.WriteLine("El valor de dandera es: " + bandera.ToString());
            Console.WriteLine("El valor de fecha es: " + fecha.ToShortDateString());
            Console.ReadKey();

        }
    }
}
