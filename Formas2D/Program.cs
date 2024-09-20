using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elipse elipse = new Elipse(12,16);
            Circulo circulo = new Circulo(8);
            Rectangulo rectangulo = new Rectangulo(20,6);
            Cuadrado cuadrado = new Cuadrado(6);
            Rombo rombo = new Rombo(4,8);
            Triangulo triangulo = new Triangulo(6,6,30);

            Console.WriteLine($@"
{circulo.ToString()}
Area del circulo: {circulo.Area()}
Perimetro del circulo: {circulo.Perimetro()}");

            Console.WriteLine($@"
{rectangulo.ToString()}
Area del rectangulo: {rectangulo.Area()}
Perimetro del rectangulo: {rectangulo.Perimetro()}");

            Console.WriteLine($@"
{cuadrado.ToString()}
Area del cuadrado: {cuadrado.Area()}
Perimetro del cuadrado: {cuadrado.Perimetro()}");

            Console.WriteLine($@"
{rombo.ToString()}
Area del rombo: {rombo.Area()}
Perimetro del rombo: {rombo.Perimetro()}");

            Console.WriteLine($@"
{triangulo.ToString()}
Area del triangulo: {triangulo.Area()}
Perimetro del triangulo: {triangulo.Perimetro()}");

            Console.WriteLine($@"
{elipse.ToString()}
Area del elipse: {elipse.Area()}
Perimetro del elipse: {elipse.Perimetro()}");
            Console.ReadKey();
        }
    }
}
