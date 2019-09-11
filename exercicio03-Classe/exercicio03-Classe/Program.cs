using System;
using System.Globalization;

namespace exercicio03_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre a largura e altura do retângulo: ");

            Retangulo retangulo;
            retangulo = new Retangulo();

            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area= "+retangulo.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro= "+retangulo.Perimetro().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal= "+retangulo.Diagonal().ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
