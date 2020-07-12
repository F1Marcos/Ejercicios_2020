using System;
using System.Collections.Generic;

namespace UNI3_Ejer_ClaseAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            UNI3 Ejer_3:
            Dadas las tres clases que se describen a continuación se pide crear el Diagrama de clase correspondiente 

            Persona 
            Tiene los atributos nombre string, apellido string, fechaNacimiento Date , dni Integer y los métodos edad() que calcula la edad de la persona, 
            y además de los métodos públicos para trabajar con los atributos correspondientes. 
            Alumno 
            Hereda de persona e incorpora el número de legajo int, fecha de ingreso y egreso ambas del tipo Date.
            Docente
            Hereda de Persona e incorpora el atributo número de legajo string, fecha de ingreso a la institución Date  y los métodos aniosDocente() que 
            calcula los años que lleva como docente y los métodos públicos para trabajar con los atributos correspondientes

            Se pide realizar la carga de un lote de alumnos y docentes a través de un menú e imprimir todas sus atributos incluyendo los valres calculados 
            (métodos)
            Las clases instánciales son únicamente Alumno y Docente
            */

            List<Persona> people = new List<Persona>(); // OJO ESTO ES SOLO EL NOMBRE DE LA LISTA!!! Y la lista es del tipo Persona !!!!
            int opcion;            
            
            do
            {
                Console.WriteLine("Ingrese:\n1 - Agregar un alumno.\n2 - Agregar un docente. \n3 - Listar edad persona asendente. \n4 - Lista fecha de ingreso alumnos. \n5 - Lista legajo docentes orden no natural. \n0 - Para salir.");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        people.Add(new Alumno());
                        //Console.WriteLine(people[0].CalculoAnios());                
                        Console.ReadKey(true);
                        break;
                    case 2:
                        Console.Clear();
                        people.Add(new Docente());
                        Console.ReadKey(true);                        
                        break;
                    case 3:
                        people.Sort();
                        OrdaneLista(people);                         
                        break;               
                    default:
                        break;
                }
            } while (opcion != 0);
            Console.WriteLine("Fin del programa");
            Console.ReadKey(true);
        }

        public static void OrdaneLista(List<Persona> people)
        {
            int i=0;
            foreach (Persona s in people)
            {
                Console.WriteLine(s.ToString());
                Console.WriteLine($"Pesona numero: {i}");
            }
        }
    }
}
