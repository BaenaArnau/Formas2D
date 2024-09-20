using System;

namespace Formas2D
{
    public class Triangulo : Poligono
    {
        protected float suelo;
        protected float altura;

        public Triangulo()
        {
        }

        public Triangulo(float suelo, float altura) : base(3)
        {
            this.suelo = suelo;
            this.altura = altura;
        }

        public float Area()
        {
            return (suelo * altura) / 2;
        }

        public float Perimetro()
        {
            float hipotenusa = (float)Math.Sqrt(Math.Pow(suelo, 2) + Math.Pow(altura, 2));
            return suelo + altura + hipotenusa;
        }

        public override string ToString()
        {
            return $"Triangulo donde su altura es de {altura} y su base es de {suelo}";
        }
    }
}