using System;

namespace PRO_EJER_2020
{
    public class Ejer03_Alumno
    {
        private string alumno;
        private float[] nota = new float[10];

        public string Alumno { get => alumno; set => alumno = value; }
        public float[] Nota { get => nota; set => nota = value; }   
        public Ejer03_Alumno()
        {
            Console.WriteLine("Ingrese el mobre del alumno:");
            this.alumno=Console.ReadLine();
            for(int i=0; i<=9; i++)
            {
            Console.WriteLine($"Ingrese la nota numero {i+1} del alumno:");
            this.nota[i]=float.Parse(Console.ReadLine());
            }
        }


        public void Promedio()
        {
            float sumaNotas=0;
            for(int i=0; i<=9; i++)          
            {
                sumaNotas+= this.nota[i];
            }
            Console.WriteLine($"El promedio del alumno {this.alumno} es: {sumaNotas/10}");
        }
        public void Aprovado()
        {
            Boolean vandera=false;
            for(int i=0; i<10; i++)
            {
                if(this.nota[i]<4)
                    vandera=true;
            }
            if(vandera)
            {
                Console.WriteLine($"El alumno {this.alumno} NO fue aprovado.");
                Console.ReadKey();
            }
            else
                Console.WriteLine($"El alumon {this.alumno} SI fue aprovado.");
                Console.ReadKey();
        }
    }
}
