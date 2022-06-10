using System;

namespace Prueba {
    class Program {
        public static void Main(string[] args)
        {
            Cuadrado F1 = new Cuadrado("C-Cuadrado","Amarillo",4);
            
            Rectangulo F2 = new Rectangulo("R-Rectangulo","Azul",5,2);
            
            Circulo F3 = new Circulo("C-Circulo","Negro",5);
            
        List<Figura> Lista_de_Figuras = new List<Figura>();
        Lista_de_Figuras.Add(F1);
        Lista_de_Figuras.Add(F2);
        Lista_de_Figuras.Add(F3);
        
        foreach(IFigura ABC in Lista_de_Figuras)
        {
            ABC.CalculoArea();
        }
        Console.ReadLine();
        }
    }
}
