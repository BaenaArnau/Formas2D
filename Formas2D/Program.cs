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
            Diagrama diagrama = new Diagrama();

            Console.WriteLine($@"
Numero de figuras {diagrama.Figuras.Count}
{diagrama.ToString()}
Area total de todas las figuras: {diagrama.Area()}
Perimetro total de todas las figuras: {diagrama.Perimetro()}");
            Console.ReadKey();
        }
    }
}
