using System;

namespace PRO_EJER_2020
{
    class Ejer02_Vendedor
    {
        private string nombre;
        private float importe_primer_semestre;
        private float importe_segundo_semestre;

        public string Nombre { get => nombre; set => nombre = value; }
        public float Importe_primer_semestre { get => importe_primer_semestre; set => importe_primer_semestre = value; }
        public float Importe_segundo_semestre { get => importe_segundo_semestre; set => importe_segundo_semestre = value; }
        public Ejer02_Vendedor()
        {
            Console.WriteLine("Ingrese el nombre del vendedor:");
            this.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el importe total vendido en el primer semestre:");
            this.importe_primer_semestre=float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el importe total vendido en el segundo semestre:");
            this.importe_segundo_semestre=float.Parse(Console.ReadLine());
        }

        public void ImporteAnual()
        {

            Console.WriteLine($"El importe anual de ventas es de: {this.importe_primer_semestre + this.importe_segundo_semestre}");
        }

        public void SemestreMejorVenta()
        {
            if(this.importe_primer_semestre >= this.importe_segundo_semestre)
            {
                    Console.WriteLine("El mejor semestre en ventas fue el primero.");
                    Console.ReadKey();
            }
            else 
            {
                if(this.importe_primer_semestre == this.importe_segundo_semestre)
                    {
                    Console.WriteLine("El mejor semestre en ventas fue igual en ambos.");
                    Console.ReadKey();
                    }
                else
                    {
                    Console.WriteLine("El mejor semestre en ventas fue el segundo.");
                    Console.ReadKey();
                    }
            }        
        }
    }
}

