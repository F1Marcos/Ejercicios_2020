using System;
using System.Collections.Generic;

namespace UNI3_Ejer_02
{
    public class Computadora
    {
        private string procesador;
        private float velocidad;
        private int tamanioMemoriaRam;
        private static int contadorTotal;
        public string Procesador { get => procesador; set => procesador = value; }
        public float Velocidad {get => velocidad; set => velocidad=value;}
        public int TamanioMemoriaRam { get => tamanioMemoriaRam; set => tamanioMemoriaRam = value; }
        public static int ContadorTotal { get => contadorTotal; set => contadorTotal = value; }

        public Computadora()
        {
            Console.WriteLine("Ingrese el tipo de procesador:");
            this.procesador=Console.ReadLine();
            Console.WriteLine("Ingrese la velocidad del procesador:");
            this.velocidad=float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tamaño de memoria RAM:");
            this.tamanioMemoriaRam=int.Parse(Console.ReadLine());
            contadorTotal++;
        }

        public virtual string ToString()
        {
            return "";
        }

    }
}
