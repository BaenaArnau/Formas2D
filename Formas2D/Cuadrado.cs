namespace Formas2D
{
    public class Cuadrado : Rectangulo
    {
        public Cuadrado()
        {
        }

        public Cuadrado(float lados) : base(lados,lados)
        {
        }

        public override string ToString()
        {
            return $"Cuadrado donde todos sus lados valen {suelo}";
        }
    }
}