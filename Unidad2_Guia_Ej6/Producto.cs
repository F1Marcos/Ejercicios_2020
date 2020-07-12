﻿using System;


namespace Unidad2_Guia_Ej6
{
    class Producto
    {
        private string descripcion;
        private string codigo;
        private int puntoDePedido;
        private int maximoStockPermitido;
        private int stockProducto;
        private double precioUnitario;

        public double PrecioUnitario {  set => precioUnitario = value; }

        public Producto()
        {
            Console.Write("\nIngrese el código de producto: ");this.codigo= Console.ReadLine();
            Console.Write("\nIngrese la descripción del producto: "); this.descripcion = Console.ReadLine();
            Console.Write("\nIngrese el punto de pedido del producto: ");this.puntoDePedido= int.Parse( Console.ReadLine());
            Console.Write("\nIngrese el máximo stock permitido del producto: ");MaximoStockPermitido( int.Parse(Console.ReadLine())); 
            Console.Write($"\nIngrese el valor del producto {this.descripcion}:"); this.precioUnitario = double.Parse(Console.ReadLine());
            this.stockProducto = 0;
        }
        public Producto(string codigo, string descripcion)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
        }
        public void Vender(int cantidad)
        {
            string mensaje="";
            if (this.stockProducto >= cantidad)
            {
                this.stockProducto = this.stockProducto - cantidad;
                mensaje = "\nSe ha vendido el producto " + this.descripcion;

                if (this.stockProducto <= this.puntoDePedido)
                {
                    mensaje = mensaje + $"\nDebe realizar una nueva compra. El stock de {this.descripcion} es {this.stockProducto} está por debajo de punto de pedido {this.puntoDePedido}";   
                }
            }else
            {
                mensaje = $"\nSolamente hay {this.stockProducto} unidades de {this.descripcion}, es insuficiente para la venta. ";
            }
            Console.WriteLine(mensaje);
        }
        public void Comprar(int cantidad)
        {
            string mensaje = "";
            if (this.maximoStockPermitido >= cantidad + this.stockProducto)
            {
                this.stockProducto = this.stockProducto + cantidad;
                mensaje = "\nSe ha comprado el producto " + this.descripcion;

                if (this.stockProducto <= this.puntoDePedido)
                {
                    mensaje = mensaje + $"\nDebe realizar una nueva compra. El stock de {this.descripcion} es {this.stockProducto} está por debajo de punto de pedido {this.puntoDePedido}";
                }
            }
            else
            {
                mensaje = $"\nLa cantidad a comprar supera el stock maximo permitido puesto que el stock actual es {this.stockProducto} y la cantidad maxima admitda es :{this.maximoStockPermitido}";
            }
            Console.WriteLine(mensaje);
        }

        public void ConsultarStock()
        {
            Console.WriteLine($"\nEl stock del producto  {this.codigo}-{this.descripcion} es: {this.stockProducto} valor unitario: {this.precioUnitario} valor del stock: {(this.stockProducto * this.precioUnitario)} ");
        }
        public void PuntoDePedido(int cantidad)
        {
            string mensaje;
            if (cantidad >= 0 && cantidad <= this.maximoStockPermitido)
            {
                this.puntoDePedido = cantidad;
                mensaje = "Se ha cambiado el punto de pedido";
            }
            else
            {
                mensaje = "No se pudo cambiar el punto de pedido";
            }
            Console.Write(mensaje);
        }
        public void MaximoStockPermitido(int cantidad)
        {
            string mensaje;
            if (cantidad >= 0 && cantidad > this.puntoDePedido)
            {
                this.maximoStockPermitido = cantidad;
                mensaje = "Se ha cambiado el stock máximo permitido";
            }
            else
            {
                mensaje = "No se pudo cambiar el stock máximo permitido";
            }
            Console.Write(mensaje);
        }

    }
}
