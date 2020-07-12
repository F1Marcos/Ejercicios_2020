using System;
using System.Collections.Generic;

namespace UNI3_Ejer_02
{
    public class SmartPhone : Computadora
    {
        private string tipoPantalla;
        private int cantidadChips;
        private int tamanioPantalla;
        private int cantidadFrecuencias;
        public string TipoPantalla { get => tipoPantalla; set => tipoPantalla = value; }
        private int TamanioPantalla { get => tamanioPantalla; set => tamanioPantalla = value; }
        public int CantidadChips { get => cantidadChips; set => cantidadChips = value; }
        public int CantidadFrecuencias { get => cantidadFrecuencias; set => cantidadFrecuencias = value; }
        public SmartPhone()
        {
            Console.WriteLine("Ingrese el tipo pantalla:");
            this.tipoPantalla=Console.ReadLine();
            Console.WriteLine("Ingrese cantidad de chips:");
            this.cantidadChips = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tamaño de la pantalla:");
            this.tamanioPantalla = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de frecuencias:");
            this.cantidadFrecuencias = int.Parse(Console.ReadLine());
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
            return ($"Notebook: Procesador: {this.Procesador}; Velocidad: {this.Velocidad}; TamañoMemoria: {this.TamanioMemoriaRam}; TipoDePantalla: {this.tipoPantalla}; CantidadChips: {this.cantidadChips}; TamañoPantalla: {this.tamanioPantalla}; CantidadFrecuencias: {this.cantidadFrecuencias}");
        }
    }
}
