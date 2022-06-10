using System;

namespace Prueba
{
    class Circulo : Figura, IFigura
    {
        public double Radio { set; get; }
        public Circulo(string Nombre, string Color, int Radio) : base (Nombre,Color)
        {
            this.Radio = Radio;
        }

        public void CalculoArea(){
            double Resul;
            Console.WriteLine("Nombre: "+Nombre);
            Console.WriteLine("Color: "+Color);
            Console.WriteLine("Radio: "+Radio+"m");
            Resul = Math.Pow(Radio, 2) * Math.PI;
            Console.WriteLine("El Calculo del Area de Circulo es: "+Resul+"m^2");
            Console.WriteLine("---------------------------------------------------");
        }
    }
}