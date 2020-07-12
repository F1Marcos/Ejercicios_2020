using System;
using System.Collections.Generic;

namespace UNI3_Ejer_02
{
    public class Notebook : Computadora
    {
        private string tipoPantalla;
        private char tieneHDD;
        private int tamanioPantalla;
        private int tamanioDisco;
        private int cantidadTeclas;

        public string TipoPantalla { get => tipoPantalla; set => tipoPantalla = value; }
        private char TieneHDD { get => tieneHDD; set => tieneHDD = value; }
        public int TamanioPantalla { get => tamanioPantalla; set => tamanioPantalla = value; }
        public int TamanioDisco { get => tamanioDisco; set => tamanioDisco = value; }
        public int CantidadTeclas { get => cantidadTeclas; set => cantidadTeclas = value; }

        public Notebook()
        {
            Console.WriteLine("Ingrese el tipo pantalla:");
            this.tipoPantalla=Console.ReadLine();
            Console.WriteLine("Ingrese si tiene HDD:");
            this.tieneHDD = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tamaño de la pantalla:");
            this.tamanioPantalla = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese tamaño de disco (s/n):");
            this.tamanioDisco = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de teclas:");
            this.cantidadTeclas = int.Parse(Console.ReadLine());
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
            return ($"Notebook: Procesador: {this.Procesador}; Velocidad: {this.Velocidad}; TamañoMemoria: {this.TamanioMemoriaRam}; TipoDePantalla: {this.tipoPantalla}; DiscoHDD: {this.tipoPantalla}; TamañoPantalla: {this.tamanioPantalla}; TamañoDisco: {this.tamanioDisco}; CantidadTeclas: {this.cantidadTeclas}");
        }
    }
}
