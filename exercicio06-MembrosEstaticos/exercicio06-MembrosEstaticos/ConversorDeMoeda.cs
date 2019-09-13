using System.Globalization;

namespace exercicio06_MembrosEstaticos
{
    public class ConversorDeMoeda
    {
          public static double Iof = 6.0;

        public static double Conversao(double dolaresComprados, double cotacao)
        {
            double total = dolaresComprados * cotacao;
            return total + total * Iof / 100.0;
        }
    }
    }

