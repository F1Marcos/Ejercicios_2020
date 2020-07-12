using System;
using System.Collections.Generic;
using System.Text;

namespace UNI3_Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi t = new Taxi();
            t.NumeroDeLicencia = 1234;
            Console.WriteLine($"Datos de taxi t {t}");

            Taxi t2 = new Taxi();
            t2.NumeroDeLicencia = 8822;
            Console.WriteLine($"Datos de taxi t2 {t2.ToString()}");

            // Comentario
            Taxi.ContadorDeTaxis = 500;

            Console.WriteLine($"Datos de taxi t {t.ToString()}");
            Console.WriteLine($"Datos de taxi t2 {t2.ToString()}");
            Console.ReadKey(true);
            }
    }
}
