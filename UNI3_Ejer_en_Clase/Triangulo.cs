using System;
using System.Collections.Generic;

namespace UNI3_Ejer_en_Clase
{
    class Triangulo:FigurasGeometricas
    {
        private int longitudLado1;
        private int longitudLado2;
        private int longitudLado3;
        private int longitudAltura;

        public int LongitudLado1 { get => longitudLado1; set => longitudLado1 = value; }
        public int LongitudLado2 { get => longitudLado2; set => longitudLado2 = value; }
        public int LongitudLado3 { get => longitudLado3; set => longitudLado3 = value; }
        public int LongitudAltura { get => longitudAltura; set => longitudAltura = value; }

        public Triangulo()
        {
            string aux; // se puede obviar la variable se incluyó solo a fines pedagogico

            Console.WriteLine("Ingrese un valor para el primer lado");
            aux = Console.ReadLine();
            this.longitudLado1 = int.Parse(aux);
            Console.WriteLine("Ingrese un valor para el segundo lado");
            aux = Console.ReadLine();
            this.longitudLado2 = int.Parse(aux);
            Console.WriteLine("Ingrese un valor para el tercer lado");
            aux = Console.ReadLine();
            this.longitudLado3 = int.Parse(aux);
            Console.WriteLine("Ingrese un valor para la altura");
            aux = Console.ReadLine();
            this.longitudAltura = int.Parse(aux);
        }


        public override double Perimetro()
        {           
            return (this.longitudLado1 + this.longitudLado2 + this.longitudLado3);
        }
        public override double Superficie()
        {
            return (this.LongitudLado1*this.LongitudAltura/2);
        }

        public override string ToString()
        {
            return ($"Triangulo: Lado 1={this.longitudLado1}; Lado 2={this.longitudLado2}; Lado 3={this.longitudLado3}; Altura={this.LongitudAltura}; Perimetro={Perimetro()}; Superficie={Superficie()}");
        }
    }
}
