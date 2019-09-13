using System;
using System.Globalization;

namespace exercicio06_MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double dolaresComprados = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.Conversao(dolaresComprados, cotacao);
            Console.Write("Valor a ser pago em reais=  " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
