using System;

namespace Formas2D
{
    public class Triangulo : Poligono
    {
        protected float suelo;
        protected float altura;
        protected float angulo;

        public Triangulo()
        {
        }

        public Triangulo(float suelo, float altura, float angulo) : base(3)
        {
            this.suelo = suelo;
            this.altura = altura;
            this.angulo = angulo;
        }

        public override float Area()
        {
            return (suelo * altura) / 2;
        }

        public override float Perimetro()
        {
            float anguloEnRadianes = (float)(Math.PI / 180) * angulo;
            float lado1 = altura / (float)Math.Sin(anguloEnRadianes);
            float lado2 = suelo / (float)Math.Cos(anguloEnRadianes);

            return suelo + lado1 + lado2;
        }

        public override string ToString()
        {
            return $"Triangulo donde su altura es de {altura}, su base es de {suelo} y el angulo entra la base y uno de sus lados es de {angulo}";
        }
    }
}