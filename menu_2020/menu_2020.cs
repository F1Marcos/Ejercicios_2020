using System;

namespace PRO_EJER_2020
{
     // DOC: http://www.forosdelweb.com/f45/consejos-para-menu-por-consola-orientado-objetos-702502/
     class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                bool continua=false;
                do
                {
                    try
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Bienvenido al TP de Progamacion_Aplicada - IFTS11 - 2020");
                            Console.WriteLine("--------------------------------------------------------");
                            Console.WriteLine("");
                            Console.WriteLine("Por favor elija un ejercicio de 1 al 1 para revisar o 0 para salir:");
                            Console.WriteLine("");
                            i = int.Parse(Console.ReadLine());
                            continua = false;
                    }
                    catch (FormatException err)
                        {
                            Console.Clear();
                            Console.Write("Debe ingresar obligatoriamente un número entero.");
                            Console.WriteLine("");
                            Console.Write("Presione una teclar para volver a intentar.");
                            Console.ReadKey();
                            continua = true;
                        }
                } while (continua);

                switch (i)
                {
                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        Console.Clear();
                        Ejer01_Triangulo var;
                        var = new Ejer01_Triangulo();
                        var.Perimetro();
                        var.Superficie();
                        break;
                    case 2:
                        Console.Clear();
                        Ejer02_Vendedor var2;
                        var2 = new Ejer02_Vendedor();
                        var2.ImporteAnual();
                        var2.SemestreMejorVenta();
                        break;
                    case 3:
                        Console.Clear();
                        Ejer03_Alumno var3;
                        var3 = new Ejer03_Alumno();
                        var3.Promedio();
                        var3.Aprovado();
                        break;
                    case 4:
                        Console.Clear();
                        Ejer04_Cuadrado var4;
                        var4 = new Ejer04_Cuadrado();
                        var4.Perimetro();
                        var4.Superficie();
                        break;
                    case 5:
                        Console.Clear();
                        Ejer05_Rectangulo var5;
                        var5 = new Ejer05_Rectangulo();
                        var5.Perimetro();
                        var5.Superficie();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Opcion invalida, vuelva a intentarlo.");
                        Console.WriteLine("Presione una tecla para volver al menu.");
                        Console.ReadKey();
                        break;
                }
            } while (i!=0);
        }
    }
}

