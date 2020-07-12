using System;
using System.Collections.Generic;
namespace UNI3_Eje_List
{
    class colectora2
    {
        static void Main(string[] args)
        {
            // Declaro una instancia...
            List<string> personasEncuestadas = new List<string>{"Martin","Eduardo","Tejerina","Orsini","Ignes","Tejerina","Tobias"};
            Console.WriteLine($"Se encuestaron {personasEncuestadas.Count} personas.");
            int i=1;
            foreach (string nombreEncuestado in personasEncuestadas)
            {
                Console.WriteLine($"Encuestado N°: {i++} {nombreEncuestado}");
                // Console.WriteLine($"Encu....)
            }

            //puedo
            //como explicamos
            personasEncuestadas.Remove("Tejerina");

            Console.WriteLine($"\nLuego de eliminar a Tejerina (la primer ocurrencia) hay: {personasEncuestadas.Count} personas.");
            i=1;
            foreach (string nombreEncuestado in personasEncuestadas)
            {
                Console.WriteLine($"Encuestado N°: {i++} {nombreEncuestado}");
                // Console.WriteLine($"Encu....)
            }

            personasEncuestadas.RemoveAt(3);
            Console.WriteLine($"\nLuego de eliminar el tercer elemento hay: {personasEncuestadas.Count} personas.");
            i=1;
            foreach (string nombreEncuestado in personasEncuestadas)
            {
                Console.WriteLine($"Encuestado N°: {i++} {nombreEncuestado}");
                // Console.WriteLine($"Encu....)
            }
            Console.WriteLine("Fin del programa");
            Console.ReadKey(true);
        }
    }
}