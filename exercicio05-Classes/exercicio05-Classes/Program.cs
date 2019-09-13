using System;
using System.Globalization;

namespace exercicio05_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1;
            aluno1 = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno1.nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno1.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno1.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno1.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno1.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno1.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Faltaram "+ aluno1.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " pontos");
            }

        }
    }
}
