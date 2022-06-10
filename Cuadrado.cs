using System;

namespace Prueba
{
    class Cuadrado : Figura, IFigura
    {
        public int Lados { set; get; }
        public Cuadrado(string Nombre, string Color, int Lados) : base (Nombre,Color)
        {
            this.Lados = Lados;
        }

        public void CalculoArea(){
            int Resul;
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Nombre: "+Nombre);
            Console.WriteLine("Color: "+Color);
            Console.WriteLine("Lados: "+Lados+"m");
            Resul = Lados * Lados;
            Console.WriteLine("El Calculo del Area de Cuadrado es: "+Resul+"m^2");
            Console.WriteLine("---------------------------------------------------");
        }
    }
}