using System;
using System.Collections.Generic;

namespace Formas2D
{
    public class Diagrama
    {
        List<Forma2D> figuras;

        public Diagrama()
        {
            figuras = new List<Forma2D>();
            Random r = new Random();
            int numFiguras = r.Next(1,100);

            Rellenar(numFiguras, r);
        }

        private void Rellenar(int numFiguras, Random r)
        {
            for (int i = 0; i < numFiguras; i++)
            {
                switch (r.Next(1,6))
                {
                    case 1:
                        figuras.Add(new Circulo(r.Next(1,100)));
                        break;
                    case 2:
                        figuras.Add(new Cuadrado(r.Next(1,100)));
                        break;
                    case 3:
                        figuras.Add(new Elipse(r.Next(1,100), r.Next(1,100)));
                        break;
                    case 4:
                        figuras.Add(new Rectangulo(r.Next(1,100), r.Next(1,100)));
                        break;
                    case 5:
                        figuras.Add(new Rombo(r.Next(1,100),r.Next(1,100)));
                        break;
                    case 6:
                        figuras.Add(new Triangulo(r.Next(1,100), r.Next(1, 100), r.Next(1, 100)));
                        break;
                }
            }
        }

        public float Area()
        {
            float resultado = 0;
            foreach (var figura in figuras)
            {
                resultado += figura.Area();
            }
            return resultado;
        }

        public float Perimetro()
        {
            float resultado = 0;
            foreach (var figura in figuras)
            {
                resultado += figura.Perimetro();
            }
            return resultado;
        }

        public List<Forma2D> Figuras { get { return figuras; } }

        public override string ToString()
        {
            string salida = "Lista de figuras: \n";
            foreach (var figura in figuras)
            {
                salida += ("- " + figura.ToString() + "\n");
            }

            return salida;
        }
    }
}