using System;
using System.Collections.Generic;

namespace UNI3_Ejer_en_Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1.Realizar un programa que permita almacenar figuras geométricas del tipo Triángulo, Cuadrado, Rectángulo y Círculos. 
            Para las figuras de tipo Triángulo, Cuadrado y Rectángulo se usarán las clases definidas en las páginas 12 y 13 del cuadernillo. 
            Mientras que para el Círculo se deberá crear una nueva clase que tendrá como atributo radio y tendrá los métodos perímetro y superficie.

            Todas las figuras geométricas deben contar con un método ToString():string para informar de los valores de sus atributos, como también 
            el de su perímetro y el de su superficie.
            
            La ejecutora deberá tener un menú que permita:
            a) Agregar elementos del tipo Triángulo, Rectángulo, Cuadrado y Circulo, todos dentro de una misma colección. 
            b) Mostrar todos los datos de cada una de las figuras geométricas (atributos y métodos), indicando que tipo de figura geométrica es.
            c) Mostrar la superficie total de las figuras geométricas almacenadas en la colección (Suma de todas las superficies)
            d) Mostrar el perímetro total de las figuras geométricas almacenadas en la colección (Suma de todos los perímetros)
            */
            
            List<FigurasGeometricas> figus = new List<FigurasGeometricas>();
            int opcion;            
            
            do
            {
                Console.WriteLine("Ingrese:\n1 - Agregar un Cuadrado.\n2 - Agregar un Rectangulo. \n3 - Agregar un triangulo. \n4 - Agregar un circulo. \n5 - Mostrar superficie total. \n6 - Mostrar perimetro total. \n7 - Mostrar todos los valores.  \n0 - Para Terminar");
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

        /*
        public static void funcion(ref List<FigurasGeometricas> figus)
        {
            double supTotal = 0;
            foreach(FigurasGeometricas i in figus)
            {
                supTotal += i.Superficie();
            }
        }
        */
    }   
}
