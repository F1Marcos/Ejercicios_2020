using System;
using System.Collections.Generic;
using System.Text;

namespace Unidad5_RelacionDeClases
{
    class Categoria
    {

        private static int idGenerador;
        private int idCategoria;
        private String descripcion;

        private static List<Categoria> listaCategoria = new List<Categoria>();

        public Categoria()
        {
            this.idCategoria = idGenerador++;
            
            Console.WriteLine("Ingrese la descripción de la categoria");
            this.descripcion =Console.ReadLine();
            listaCategoria.Add(this);
        }

        public static void mostrarCategorias()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Categorias disponibles:");
            Console.WriteLine("--------------------");
            foreach (Categoria objCategoria in listaCategoria)
            {
                Console.WriteLine($"|ID:{objCategoria.idCategoria}    |{objCategoria.descripcion} |");
            }
            Console.WriteLine();
        }
        public static int cantidadCategorias()
        {
            return listaCategoria.Count;
        }

        public static Categoria obtenerCategoria(int idCategoria)
        {
            return listaCategoria.Find(x => x.idCategoria == idCategoria);

        }

        public override string ToString()
        {
            //return ($"{this.idCategoria}   -   Descripcion:{this.descripcion}");
            return ($"{this.descripcion}");
        }

    }
}