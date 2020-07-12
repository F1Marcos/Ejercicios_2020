using System;
using System.Collections.Generic;

namespace UNI3_Ejer_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            2) Tomando como base el diagrama de clase anterior se pide crear un programa que permita crear objetos del tipo PcEscritorio, Notebook, 
            SmartPhone y PcAllInOne. Cada clase deberá ser responsable de administrar la carga de los datos en el constructor default. Agregar al 
            diagrama de clase un método ToString para que cada una pueda devolver la información correspondiente a su tipo.

            A - El programa debe contar con métodos para poder: 
                a) cargar cada uno de los objetos
                b) listar todos los objetos creados visualizando todo los atributos 
                c) eliminar un objeto en particular (se debe poder seleccionar un objeto y sacarlo de la colección)
            B - Debe informar la cantidad de computadoras creadas estén o no dentro de la colección.
            */

            List<Computadora> compu = new List<Computadora>();
            int opcion;            
            
            do
            {
                Console.WriteLine("Ingrese:\n1 - Agregar una PC de Escritorio.\n2 - Agregar una Notebook. \n3 - Agregar un SmartPhone. \n4 - Agregar un PC AllInOne.");
                Console.WriteLine("\n5 - Mostrar todas las computadoras en detalle. \n6 - Eliminar una computadora. \n7 - Informar total de computadoras.  \n0 - Para Terminar");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        compu.Add(new Notebook());
                        break;
                    case 2:
                        Console.Clear();
                        compu.Add(new PcEscritorio());
                        break;
                    case 3:
                        Console.Clear();
                        compu.Add(new SmartPhone());
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("\n\n----------------");
                        foreach(Computadora i in compu)
                        {
                            Console.WriteLine(i.ToString());
                        }
                        Console.WriteLine("----------------");
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine($"El total de computadoras es de: {Computadora.ContadorTotal}");
                        break;                                  
                    default:
                        break;
                }
            } while (opcion != 0);
            Console.WriteLine("Fin del programa");
            Console.ReadKey(true);

        }
    }
}
