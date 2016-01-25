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
        //Al poner un dato como privado, ya no es una propiedad, es un campo, por lo que se refactoriza
        private string _Nombre;

        private decimal _SueldoDiario;

        private int _Edad;

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }


        public decimal SueldoDiario { get; set; }//hecho con prop 2tab

       /* public decimal SueldoDiario
        {
            get
            {
                return _SueldoDiario;
            }

            set
            {
                _SueldoDiario = value;
            }
        }*/

        public int Edad
        {
            get
            {
                return _Edad;
            }

            set
            {
                _Edad = value;
            }
        }

        //Metodos de la clase
        public decimal CalculaSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias;
        }
    }
    
}
