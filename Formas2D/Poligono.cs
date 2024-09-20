namespace Formas2D
{
    public abstract class Poligono : Forma2D
    {
        protected int numeroDeLados;

        public Poligono()
        {
        }

        public Poligono(int numeroDeLados)
        {
            this.numeroDeLados = numeroDeLados;
        }
    }
}