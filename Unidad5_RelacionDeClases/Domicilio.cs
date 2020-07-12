using System;
using System.Collections.Generic;
using System.Text;

namespace Unidad5_RelacionDeClases
{
    class Domicilio
    {
        private  static int idGenerador;
        private int idDomicilio;
        private string calle, localidad, provincia;
        private int numero;
        public static int IdGenerador { get => idGenerador; set => idGenerador = value; }
        public int IdDomicilio { get => idDomicilio; set => idDomicilio = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public int Numero { get => numero; set => numero = value; }
        public Domicilio()
        {         
            int aux;
            this.IdDomicilio = IdGenerador++;
            Console.WriteLine("Ingrese el nombre de la calle");
            this.Calle = Console.ReadLine();
            do{
            Console.WriteLine("Ingrese el número de la calle");
            }while(int.TryParse(Console.ReadLine(), out aux) is false);
            this.Numero=aux;
            Console.WriteLine("Ingrese el nombre de la localidad");
            this.Localidad = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la Provincia");
            this.Provincia = Console.ReadLine();
        }

        public override string ToString()
        {
            return ($"Direccion:{this.calle} {this.numero}");
        }
    }
}