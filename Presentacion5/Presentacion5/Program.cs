using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion5
{
    class Program
    {
        static void Main(string[] args)
        {
            clsEmpleados empleado;// se crea el empleado
            empleado = new clsEmpleados();// se instancia el empleado
            empleado.Edad = 25;
            empleado.Nombre = "Isidro hernández";
            empleado.SueldoDiario = 12.5m;
           
            decimal total;
            total = empleado.CalculaSalario(30);
            Console.WriteLine("El nombre del empleado es: " + empleado.Nombre);
            Console.WriteLine("El salario mensual del empleado es: " + total.ToString("C"));
            Console.ReadKey();

        }
    }
}
