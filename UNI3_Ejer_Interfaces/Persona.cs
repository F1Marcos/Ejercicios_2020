using System;
using System.Collections.Generic;

namespace UNI3_Ejer_Interfaces
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private integer dni;


        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public integer Dni { get => dni; set => dni = value; }

        public Persona()
        {
            Console.WriteLine("Ingrese el nombre");
            this.nombre=Console.ReadLine();
            Console.WriteLine("Ingrese el apellido:");
            this.apellido=Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento con el siguiente formato MM/DD/YYYY:");
            this.fechaNacimiento=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el DNI:");
            this.dni=integer.Parse(Console.ReadLine());
        }
        public int edad()
        {
            // Obtiene la fecha actual:
            DateTime fechaActual = DateTime.Today;
            int edad;
            // Comprueba que la se haya introducido una fecha válida; si
            // la fecha de nacimiento es mayor a la fecha actual se muestra mensaje
            // de advertencia:
            if (this.fechaNacimiento > fechaActual)
            {
                Console.WriteLine ("La fecha de nacimiento es mayor que la actual.");
                return -1;
            }
            else
            {
                edad = fechaActual.Year - this.fechaNacimiento.Year;
               
                // Comprueba que el mes de la fecha de nacimiento es mayor
                // que el mes de la fecha actual:
                if (this.fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }
            }
            return edad;
        }

        public virtual string ToString()
        {
            return "";
        }
    }
}