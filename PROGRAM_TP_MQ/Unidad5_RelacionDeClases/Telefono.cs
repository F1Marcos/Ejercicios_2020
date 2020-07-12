using System;
using System.Collections.Generic;
using System.Text;

namespace Unidad5_RelacionDeClases
{
    public class Telefono
    {
        private static int idGenerador = 0;
        private int idTelefono;
        private int caracteristica = -1;
        private int numeroLocal;
        public int Caracteristica {get => caracteristica; set => caracteristica =value; }
        public int NumeroLocal {get => numeroLocal; set => numeroLocal = value;}
        public Telefono()
        {
            this.idTelefono = idGenerador;
            idGenerador++;
            do{
                Console.WriteLine("Ingrese la caracteristica telefonica:");
            }while(int.TryParse(Console.ReadLine(), out this.caracteristica) is false);

            do{
                Console.WriteLine("Ingrese el numero local telefonico:");
            }while(int.TryParse(Console.ReadLine(), out this.numeroLocal) is false);
        }
        public override string ToString()
        {
            return ($"{this.caracteristica}-{this.numeroLocal}");
        }
    }
}
