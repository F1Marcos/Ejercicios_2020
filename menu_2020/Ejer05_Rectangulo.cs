using System;

namespace PRO_EJER_2020
{
    public class Ejer05_Rectangulo
    {
        private int longitudLado1;
        private int longitudLado2;

        public int LongitudLado1 { get => longitudLado1; set => longitudLado1 = value; }
        public int LongitudLado2 { get => longitudLado2; set => longitudLado2 = value; }
        public Ejer05_Rectangulo()
        {
            string aux; // se puede obviar la variable se incluyó solo a fines pedagogico
            Console.WriteLine("Ingrese un valor para el primer lado");
            aux = Console.ReadLine();
            this.longitudLado1 = int.Parse(aux);
            Console.WriteLine("Ingrese un valor para el segundo lado");
            aux = Console.ReadLine();
            this.longitudLado2 = int.Parse(aux);
        }


        public void Perimetro()
        {        
            Console.WriteLine($"El perímetro del rectangulo es: {this.longitudLado1*2 + this.longitudLado2*2 }");
        }
        public void Superficie()
        {
            Console.WriteLine($"La superficie el rectangulo es: {this.LongitudLado1*this.LongitudLado2}");
        }
    }
}
