namespace Formas2D
{
    public class Rectangulo : Poligono
    {
        protected float suelo;
        protected float altura;

        public Rectangulo()
        {
        }

        public Rectangulo(float suelo, float altura) : base(4)
        {
            this.suelo = suelo;
            this.altura = altura;
        }

        public override float Area()
        {
            return suelo * altura;
        }

        public override float Perimetro()
        {
            return suelo + suelo + altura + altura;
        }

        public override string ToString()
        {
            return $"Rectangulo que tiene {altura} de altura y {suelo} de base";
        }
    }
}