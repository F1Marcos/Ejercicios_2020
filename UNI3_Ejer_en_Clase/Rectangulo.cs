using System;
using System.Collections.Generic;

namespace UNI3_Ejer_en_Clase
{
    public class Rectangulo:FigurasGeometricas
    {
        private int longitudLado1;
        private int longitudLado2;

        public int LongitudLado1 { get => longitudLado1; set => longitudLado1 = value; }
        public int LongitudLado2 { get => longitudLado2; set => longitudLado2 = value; }
        public Rectangulo()
        {
            string aux; // se puede obviar la variable se incluyó solo a fines pedagogico
            Console.WriteLine("Ingrese un valor para el primer lado");
            aux = Console.ReadLine();
            this.longitudLado1 = int.Parse(aux);
            Console.WriteLine("Ingrese un valor para el segundo lado");
            aux = Console.ReadLine();
            this.longitudLado2 = int.Parse(aux);
        }


        public override double Perimetro()
        {        
            return (this.longitudLado1*2 + this.longitudLado2*2);
        }
        public override double Superficie()
        {
            return (this.LongitudLado1*this.LongitudLado2);
        }

        public override string ToString()
        {
            return ($"Rectangulo: Lado 1={this.longitudLado1}; Lado 2={this.longitudLado2}; Perimetro={Perimetro()}; Superficie={Superficie()}");
        }
    }
}
