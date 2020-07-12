using System;
using System.Globalization;

namespace Ejer01_Triangulo
{
    class Ejecutora
    {
        static void Main(string[] args)
        {
            int opcion;
            
            Triangulo t;
            do
            {
                
                Console.WriteLine("Ingrese:\n 1 para crear un triangulo y mostrar su perímetro y superficie\n 0 Para Terminar");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    t = new Triangulo();
                
                    t.Perimetro();
                    t.Superficie();
                }
               
            } while (opcion != 0);
            Console.WriteLine("Fin del programa");

            //===================================================
            //PRUEBA VERIFICACION TryParse
            DateTime dt;
            do{
            Console.WriteLine("DD/MM/YYYY");
            //dt = DateTime.ParseExact(Console.ReadLine(), "01/12/2020", System.Globalization.CultureInfo.InvariantCulture);
            }while(!(DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out dt)));
            Console.WriteLine(dt);

            Console.WriteLine(dt.ToString("dd/MM/yyyy"));
            //FIN PRUEBA =========================================
            Console.ReadKey(true);
        }
    }
}
