using System;

namespace Formas2D
{
    public class Elipse : Forma2D
    {
        protected float radio1;
        protected float radio2;

        public Elipse()
        {
        }

        public Elipse(float radio1, float radio2)
        {
            this.radio1 = radio1;
            this.radio2 = radio2;
        }

        public float Area()
        {
            return radio1 * radio2 * (float)Math.PI; 
        }

        public float Perimetro()
        {
            float pi = (float)Math.PI;
            float term1 = 3 * (radio1 + radio2);
            float term2 = (float)Math.Sqrt((3 * radio1 + radio2) * (radio1 + 3 * radio2));

            return pi * (term1 - term2);
        }

        public override string ToString()
        {
            return $"Eclipse donde su radio horizontal es {radio1} y el vertical es {radio2}";
        }
    }
}