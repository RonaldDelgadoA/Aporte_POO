using System;

namespace Prueba
{
    class Figura
    {
        public string Nombre { set; get; }
        public string Color { set; get; }

        public Figura(string Nombre, string Color)
        {
            this.Nombre = Nombre;
            this.Color = Color;
        }
    }
}