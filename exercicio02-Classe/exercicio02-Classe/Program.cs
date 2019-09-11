using System;
using System.Globalization;

namespace exercicio02_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0.0;
            Funcionario funcionario1, funcionario2;
            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro usuário");
            Console.Write("Nome: ");
            funcionario1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo usuário");
            Console.Write("Nome: ");
            funcionario2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (funcionario1.salario + funcionario2.salario) / 2.0;
            Console.WriteLine("Salário médio= "+media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
