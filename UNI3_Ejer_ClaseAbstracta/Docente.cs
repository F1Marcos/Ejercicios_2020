using System;
using System.Collections.Generic;

namespace UNI3_Ejer_ClaseAbstracta
{
    public class Docente : Persona, IComparable
    {
        private int legajo;
        private DateTime ingreso;
        private DateTime egreso;


        public int Legajo { get => legajo; set => legajo = value; }
        public DateTime Ingreso { get => ingreso; set => ingreso = value; }
        public DateTime Egreso { get => egreso; set => egreso = value; }

        public Docente()
        {
            Console.WriteLine("Ingrese el numero de legajo:");
            this.legajo=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de ingreso con el siguiente formato MM/DD/YYYY:");
            this.ingreso=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de egreso con el siguiente formato MM/DD/YYYY:");
            this.egreso=DateTime.Parse(Console.ReadLine());
        }
        
        public int aniosDocente()
        {
            // Obtiene la fecha actual:
            DateTime fechaActual = DateTime.Today;
            int antiguedad;
            // Comprueba que la se haya introducido una fecha válida; si
            // la fecha de nacimiento es mayor a la fecha actual se muestra mensaje
            // de advertencia:
            if (this.ingreso > fechaActual)
            {
                Console.WriteLine ("La fecha de ingreso es mayor que la actual.");
                return -1;
            }
            antiguedad = fechaActual.Year - this.ingreso.Year;
            return antiguedad;
        }

        public override string ToString()
        {
            //return ($"{this.legajo}{Nombre}{Apellido}");
            return ($"Legajo={this.legajo}; Ingreso={this.ingreso}; Egreso={this.egreso} ;Nombre={Nombre}; Apellido={Apellido} Fecha Nacimiento={FechaNacimiento}; Edad={CalculoAnios(FechaNacimiento)}");
        }
    }
}
