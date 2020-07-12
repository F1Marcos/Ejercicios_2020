using System;
using System.Collections.Generic;

namespace TP_FINAL
{
    public class Domicilio
    {
        /*
        Tiene los atributos:  idDomicilio int, calle String, numero String,  localidad String,  provincia String.      
        Tiene un método domicilio() El método domicilio devuelve los datos formateados del domicilio a partir del id. ¿Cuál id? .
        */
        private int idDomicilio;
        private string calle;
        private string numero;
        private string localidad;
        private string provincia;

        public string IdDomicilio { get => idDomicilio; set => idDomicilio=value; }
        public string Calle { get => calle; set => calle = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public Domicilio()
        {
            Console.WriteLine("Ingrese el domicilio:");
            this.domicilio=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la calle:");
            this.calle=Console.ReadLine();
            Console.WriteLine("Ingrese el numero:");
            this.numero=Console.ReadLine();
            Console.WriteLine("Ingrese la localidad:");
            this.localidad=Console.ReadLine();
            Console.WriteLine("Ingrese la provincia:");
            this.provincia=Console.ReadLine();
        }
    }
}
