using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion5
{
    public class clsEmpleados
    {
        public clsEmpleados()
        {
            Nombre = "";
            SueldoDiario = 0.0m;
            Edad = 0;
        }

        //Propiedades oublicas de una clase
        public string Nombre;
        public decimal SueldoDiario;
        public int Edad;

        //Metodos de la clase
        public decimal CalculaSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias;
        }
    }
    
}
