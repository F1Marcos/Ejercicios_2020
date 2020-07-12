using System;
using System.Collections.Generic;

namespace UNI3_Ejer_02
{
    public class PcEscritorio : Computadora
    {
        private string tamanioGabinete;
        private char tieneHDD;
        private char tieneDVD;
        private int tamanioDisco;
        public string TamanioGabinete { get => tamanioGabinete; set => tamanioGabinete = value; }
        private char TieneHDD { get => tieneHDD; set => tieneHDD = value; }
        public char TieneDVD { get => tieneDVD; set => tieneDVD = value; }
        public int TamanioDisco { get => tamanioDisco; set => tamanioDisco = value; }
        public PcEscritorio()
        {
            Console.WriteLine("Ingrese el tamaño del gabinete:");
            this.tamanioGabinete=Console.ReadLine();
            Console.WriteLine("Ingrese si tiene HDD:");
            this.tieneHDD = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tamaño de la pantalla:");
            this.tieneDVD = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tamaño de disco (s/n):");
            this.tamanioDisco = int.Parse(Console.ReadLine());
        }

        /*
        public override double Perimetro()
        {           
            return (this.longitudLado1 + this.longitudLado2 + this.longitudLado3);
        }
        public override double Superficie()
        {
            return (this.LongitudLado1*this.LongitudAltura/2);
        }
        Procesador: {Computadora.procesador}; Velocidad: {velocidad}; MemoriaRAM: {tamanioMemoriaRam}; 
        */
        public override string ToString()
        {
            return ($"Notebook: Procesador: {this.Procesador}; Velocidad: {this.Velocidad}; TamañoMemoria: {this.TamanioMemoriaRam}; TamañoGabinete: {this.tamanioGabinete}; TieneDVD: {this.tieneDVD}; TamañoDisco: {this.tamanioDisco}");
        }
    }
}
