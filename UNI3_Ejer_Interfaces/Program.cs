using System;

namespace UNI3_Ejer_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Dadas las tres clases que se describen a continuación se pide crear el Diagrama de clase correspondiente 
                Persona: Tiene los atributos nombre string, apellido string, fechaNacimiento Date , dni Integer y los métodos edad() que calcula la edad de la persona, y además de los métodos públicos para trabajar con los atributos correspondientes. 
                Alumno: Hereda de persona e incorpora el número de legajo int, fecha de ingreso y egreso ambas del tipo Date.
                Docente: Hereda de Persona e incorpora el atributo número de legajo string, fecha de ingreso a la institución Date  y los métodos aniosDocente() que calcula los años que lleva como docente y los métodos públicos para trabajar con los atributos correspondientes
            * Se pide realizar la carga de un lote de alumnos y docentes a través de un menú e imprimir todos sus atributos incluyendo los valores calculados (métodos)
            * Las clases instánciales son únicamente Alumno y Docente

            * Definir un ordenamiento natural de Alumnos y Docentes dado por la edad ascendente.
            	Definir un ordenamiento no natural de Alumnos dado por fecha de ingreso ascendente
            	Definir un ordenamiento no natural de docentes  dado por el número de legajo

            * Crear una interface llamada Recreo que tendrá que implementar el método lugar de recreo. En el caso de los alumnos enviará el mensaje string “Recreo en patio”, mientras que la implementación en profesores será un mensaje “Recreo en sala de profesores”

            Formateo de fechas
            * Crea un objeto dt del tipo date time 2008-03-09 16:05:07.123
            DateTime dt = new DateTime(2008, 3, 9, 16, 5, 7, 123);

            * Crea un objeto dt del tipo DateTime, predeterminado con la fecha-hora del actual
            DateTime dt = DateTime.Now;
            string fecha = String.Format("{0: MM/dd/yyyy}", dt);
            */
            List<FigurasGeometricas> figus = new List<FigurasGeometricas>();
            int opcion;            
            
            do
            {
                Console.WriteLine("Ingrese:\n1 - Agregar un Alumno.\n2 - Agregar un Docente. \n3 - Ordenar persona asendente. \n4 - Fecha de ingreso alumno asendente. \n5 - Ordenar docente por legajo - no natural. \n0 - Para Terminar");
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
    }
}
