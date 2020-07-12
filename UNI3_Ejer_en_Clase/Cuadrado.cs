using System;
using System.Collections.Generic;

namespace UNI3_Ejer_en_Clase
{
    public class Cuadrado:FigurasGeometricas
    {
        private int longitudLado1;

        public int LongitudLado1 { get => longitudLado1; set => longitudLado1 = value; }

        public Cuadrado()
        {
            string aux; // se puede obviar la variable se incluyó solo a fines pedagogico
            Console.WriteLine("Ingrese uel lado del cuadrado");
            aux = Console.ReadLine();
            this.longitudLado1 = int.Parse(aux);
        }

        public override double Perimetro()
        {
            return (this.longitudLado1 * 4);
        }
        public override double Superficie()
        {
            return (this.LongitudLado1 * this.longitudLado1);
        }

        public override string ToString()
        {
            return ($"Cuadrado: Longitud={this.longitudLado1}; Perimetro={Perimetro()}; Superficie={Superficie()}");
        }
    }
}
