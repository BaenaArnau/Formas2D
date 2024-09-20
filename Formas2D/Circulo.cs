using System;
using System.Data;

namespace Formas2D
{
    public class Circulo : Elipse
    {
        public Circulo()
        {
        }

        public Circulo(float radio) : base(radio,radio)
        {
        }

        public float Area()
        {
            return (float)Math.PI * radio1 * radio1;
        }

        public float Perimetro()
        {
            return 2 * (float)Math.PI * radio1;
        }

        public override string ToString()
        {
            return $"Circulo que su radio vale {radio1}";
        }
    }
}