using System;

namespace Prueba
{
    class Rectangulo : Figura, IFigura
    {
        public int Base { set; get; }
        public int Altura { set; get; }
        public Rectangulo(string Nombre, string Color, int Base, int Altura) : base (Nombre,Color)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public void CalculoArea(){
            int Resul;
            Console.WriteLine("Nombre: "+Nombre);
            Console.WriteLine("Color: "+Color);
            Console.WriteLine("Base: "+Base+"m");
            Console.WriteLine("Altura: "+Altura+"m");
            Resul = Base * Altura;
            Console.WriteLine("El Calculo del Area de Rectangulo es: "+Resul+"m^2");
            Console.WriteLine("---------------------------------------------------");
        }
    }
}