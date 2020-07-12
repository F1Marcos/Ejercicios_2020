using System;

namespace Unidad2_Guia_Ej6
{
    class Ejecutora
    {
        static void Main(string[] args)
        {
        
            int opcion, cantidad;
            string menu = "\n\nMenu:\n1 crear producto\n2 comprar\n3 vender \n4 consultar Stock \n5 modificar punto de pedido \n6 modificar stock Maximo \n7 modificar precio unitario\n0 Salir";
            Producto p=null;
           
            do
            {
                Console.WriteLine(menu);
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        if (p == null) {
                            Console.WriteLine("Oprima 1 para crear el producto con datos mínimos 2 para completar todos los datos");
                            if (Console.ReadLine().Equals("2"))
                                p = new Producto();
                            else
                            {
                                Console.WriteLine("Ingrese el código y descripción del producto");
                                p = new Producto(Console.ReadLine(), Console.ReadLine());
                            }
                        }
                        else { Console.WriteLine("El producto ya está creado!");
                        }
                        break;
                    case 2:
                        if (p != null)
                        {
                            Console.WriteLine("Ingrese la cantidad a comprar");
                            cantidad = int.Parse(Console.ReadLine());
                            p.Comprar(cantidad);
                        }
                        else { Console.WriteLine("El producto no está creado");
                        }
                        break;
                    case 3:
                        if (p != null)
                        {

                            Console.WriteLine("Ingrese la cantidad a vender");
                            cantidad = int.Parse(Console.ReadLine());
                            p.Vender(cantidad);
                        }
                        else
                        { Console.WriteLine("El producto no está creado");
                        }
                        break;
                    case 4:
                        if (p != null)
                        {
                            p.ConsultarStock();
                        }
                        else
                        { Console.WriteLine("El producto no está creado");
                        }
                        break;
                    case 5:
                        if (p != null)
                        {
                            Console.WriteLine("Ingrese el nuevo punto de pedido");
                            cantidad = int.Parse(Console.ReadLine());
                            p.PuntoDePedido(cantidad);
                        }
                        else
                        { Console.WriteLine("El producto no está creado");
                        }
                        break;
                    case 6:
                        if (p != null)
                        {
                            Console.WriteLine("Ingrese el nuevo stock máximo permitido");
                            cantidad = int.Parse(Console.ReadLine());
                            p.MaximoStockPermitido(cantidad);
                        }
                        else
                        {
                            Console.WriteLine("El producto no está creado");
                        }
                        break;
                    case 7:
                        if (p != null)
                        {
                            Console.WriteLine("\nIngrese el nuevo valor unitario del producto");
                            p.PrecioUnitario = float.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("El producto no está creado");
                        }
                        break;
                    default:
                        Console.WriteLine("la opción ingresada no es correcta");
                        break;
                }

            } while (opcion != 0);
            Console.WriteLine("Fin del programa");
            Console.ReadKey(true);
            
        }
    }
}
