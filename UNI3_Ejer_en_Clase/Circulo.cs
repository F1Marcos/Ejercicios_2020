using System;
using System.Collections.Generic;

namespace UNI3_Ejer_en_Clase
{
    public class Circulo:FigurasGeometricas
    {
        private double radio;

        public double Radio { get => radio; set => radio = value; }

        public Circulo()
        {
            Console.WriteLine("Ingrese uel lado del cuadrado");
            this.radio  = double.Parse(Console.ReadLine());
        }

        public override double Perimetro()
        {
            return (this.radio * Math.PI);
        }
        public override double Superficie()
        {
            return (this.radio * Math.PI * Math.PI);
        }

        public override string ToString()
        {
            return ($"Circulo: Radio={this.radio}; Perimetro={Perimetro()}; Superficie={Superficie()}");
        }
    }
}
