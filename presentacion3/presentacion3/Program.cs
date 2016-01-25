using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversiones de tipo
            int i = 10;
            decimal x = 12.2m;
            bool bandera = true;
            string cadena ="123348";
            DateTime fecha = DateTime.MinValue;
            string mod = "Momdificacion en ModProy3";
            //i = (int)x;
            //i = Convert.ToInt32(x);
            i = Convert.ToInt32(cadena);
            Console.WriteLine("Hola banda del Git");
            Console.WriteLine("El valor de i es: {0}", i);
            Console.WriteLine("El valor de x es: {0:C}", x);
            Console.WriteLine("El valor de bandera es: " + bandera.ToString());
            Console.WriteLine("El valor de Cadena es: " + cadena);
            Console.WriteLine("El valor de fecha es: " + fecha.ToShortDateString());
            Console.WriteLine(mod);
            //Modificacion hecha en ModProy3
            Console.WriteLine(i + (int)x);
            Console.ReadKey();
        }
    }
}
