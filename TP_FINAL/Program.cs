using System;
using System.Collections.Generic;

namespace TP_FINAL
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<FigurasGeometricas> figus = new List<FigurasGeometricas>();
            int opcion;            
            
            do
            {
                Console.WriteLine("1 - Agregar alumno.");
                Console.WriteLine("2 - Agregar categoria.");
                Console.WriteLine("3 - Agregar materias.");
                Console.WriteLine("4 - Asignar categoria a un alumno.");
                Console.WriteLine("5 - Asignar alumno a una materia.");
                Console.WriteLine("6 - Eliminar alumno de una materia.");
                Console.WriteLine("7 - Listar alumnos de una materia.");
                Console.WriteLine("8 - Listar materias asignadas a un alumno.");
                Console.WriteLine("9 - Listar todos los datos de un alumno.");
                Console.WriteLine("0 - Para Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        figus.Add(new Cuadrado());
                        break;
                    case 2:
                        Console.Clear();
                        figus.Add(new Rectangulo());
                        break;
                    case 3:
                        Console.Clear();
                        figus.Add(new Triangulo());
                        break;
                    case 4:
                        Console.Clear();
                        figus.Add(new Circulo());
                        break; 
                    case 5:
                        Console.Clear();
                        double supTotal = 0;
                        foreach(FigurasGeometricas i in figus)
                        {
                            supTotal += i.Superficie();
                        }
                        Console.WriteLine("\n\n----------------");
                        Console.WriteLine($" Superficie total: {supTotal}");
                        Console.WriteLine("----------------");
                        break;
                    case 6:
                        Console.Clear();
                        double perTotal = 0;
                        foreach(FigurasGeometricas i in figus)
                        {
                            perTotal += i.Perimetro();
                        }
                        Console.WriteLine("\n\n----------------");
                        Console.WriteLine($"Perimetro total: {perTotal}");
                        Console.WriteLine("----------------");
                        break;
                    case 7:
                       Console.Clear();
                       Console.WriteLine("\n\n----------------");
                        foreach(FigurasGeometricas i in figus)
                        {
                            Console.WriteLine(i.ToString());
                        }
                        Console.WriteLine("----------------");
                       break;                                                
                    default:
                        break;
                }
            } while (opcion != 0);
            Console.WriteLine("Fin del programa");
            Console.ReadKey(true);
        }

        public static void ValidaASCI(int valor)
        {
            if(int.TryParse(valor, out int resultado))
            {    
                return(resultado);
            }
            else
            {
                return(0);
            } 
        }

    }
}
