using System;
using System.Collections.Generic;

namespace UNI3_Ejer_ClaseAbstracta
{
    public class Alumno : Persona, IComparable
    {
        private int legajo;
        private DateTime ingreso;
        private DateTime egreso;


        public int Legajo { get => legajo; set => legajo = value; }
        public DateTime Ingreso { get => ingreso; set => ingreso = value; }
        public DateTime Egreso { get => egreso; set => egreso = value; }

        public Alumno()
        {
            Console.WriteLine("Ingrese el numero de legajo:");
            this.legajo=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de ingreso con el siguiente formato MM/DD/YYYY:");
            this.ingreso=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de egreso con el siguiente formato MM/DD/YYYY:");
            this.egreso=DateTime.Parse(Console.ReadLine());
        }
        
        public override string ToString()
        {
            return ($"Legajo={this.legajo}; Ingreso={this.ingreso}; Egreso={this.egreso} ;Nombre={Nombre}; Apellido={Apellido} Fecha Nacimiento={FechaNacimiento}; Edad={CalculoAnios(FechaNacimiento)}");
        }
    }
}
