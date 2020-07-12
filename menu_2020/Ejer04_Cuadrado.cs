using System;

namespace PRO_EJER_2020
{
    public class Ejer04_Cuadrado
    {

        private int longitudLado1;

        public int LongitudLado1 { get => longitudLado1; set => longitudLado1 = value; }

        public Ejer04_Cuadrado()
        {
            string aux; // se puede obviar la variable se incluyó solo a fines pedagogico

            Console.WriteLine("Ingrese uel lado del cuadrado");
            aux = Console.ReadLine();
            this.longitudLado1 = int.Parse(aux);
        }

        public void Perimetro()
        {
            Console.WriteLine($"El perímetro del cuadrado es: {this.longitudLado1 * 4}");
        }
        public void Superficie()
        {
            Console.WriteLine($"La superficie el cuadrado es: {this.LongitudLado1 * this.longitudLado1}");
        }
    }
}
