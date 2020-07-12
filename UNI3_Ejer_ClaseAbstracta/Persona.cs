using System;
using System.Collections.Generic;

namespace UNI3_Ejer_ClaseAbstracta
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int dni;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Dni { get => dni; set => dni = value; }

        public Persona()
        {
            Console.WriteLine("Ingrese el nombre");
            this.nombre=Console.ReadLine();
            Console.WriteLine("Ingrese el apellido:");
            this.apellido=Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento con el siguiente formato MM/DD/YYYY:");
            this.fechaNacimiento=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el DNI:");
            this.dni=int.Parse(Console.ReadLine());
        }
        public int CalculoAnios(DateTime var)
        {
            // Obtiene la fecha actual:
            DateTime fechaActual = DateTime.Today;
            int CalculoAnios;
            // Comprueba que la se haya introducido una fecha válida; si
            // la fecha de nacimiento es mayor a la fecha actual se muestra mensaje
            // de advertencia:
            if (var > fechaActual)
            {
                Console.WriteLine ("La fecha de nacimiento es mayor que la actual.");
                return -1;
            }
            else
            {
                CalculoAnios = fechaActual.Year - var.Year;
               
                // Comprueba que el mes de la fecha de nacimiento es mayor
                // que el mes de la fecha actual:
                if (var.Month > fechaActual.Month)
                {
                    --CalculoAnios;
                }
            }
            return CalculoAnios;
        }
        
        public int CompareTo(object obj) 
        { 
            Persona doc = (Persona)obj; 
            if (CalculoAnios(this.fechaNacimiento) < doc.CalculoAnios(doc.FechaNacimiento)) return -1; 
            else if (CalculoAnios(this.fechaNacimiento) > doc.CalculoAnios(doc.FechaNacimiento)) return 1; 
            else return 0;
        } 

        public virtual string ToString()
        {
            return "";
        }
    }
}


