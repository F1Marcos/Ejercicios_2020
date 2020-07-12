using System;

namespace UNI3_Ejemplo
{
    public class Taxi
    {
        private static int contadorDeTaxis;
        private int numeroDeLicencia;
        public static int ContadorDeTaxis {get => contadorDeTaxis; set => contadorDeTaxis = value;}
        public int NumeroDeLicencia { get => numeroDeLicencia; set => numeroDeLicencia = value;}

        public Taxi()
        {
            contadorDeTaxis++;
        }

        public override string ToString()
        {
            return ($"El taxi tiene el numero de licencia: {this.NumeroDeLicencia}, la cantidad de taxis creados es: {contadorDeTaxis}");
        }
    }
}
