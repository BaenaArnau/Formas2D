using System;
using System.Runtime.InteropServices;

namespace Formas2D
{
    public class Rombo : Poligono
    {
        protected float diagonal1;
        protected float diagonal2;

        public Rombo()
        {
        }

        public Rombo(float diagonal1, float diagonal2) : base(4)
        {
            this.diagonal1 = diagonal1;
            this.diagonal2 = diagonal2;
        }

        public float Area()
        {
            return (diagonal2 * diagonal1) / 2;
        }

        public float Perimetro()
        {
            float lado = (float)Math.Sqrt(Math.Pow(diagonal1 / 2, 2) + Math.Pow(diagonal2 / 2, 2));
            return lado + lado + lado + lado;
        }

        public override string ToString()
        {
            return $"Rombo donde la diagonal horizontal es de {diagonal1} y la vertical es de {diagonal2}";
        }
    }
}