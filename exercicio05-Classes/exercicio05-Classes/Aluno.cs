using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio05_Classes
{
    class Aluno
    {
        public string nome;
        public double nota1, nota2, nota3;

        public double NotaFinal()
        {
            return nota1 + nota2 + nota3;
        }
        public bool Aprovado()
        {
            if(NotaFinal()>= 60)
            {
                return true;
            }
            else
            {
                return false; 
                   
            }
        }
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return (60 - NotaFinal()); 

            }
        }
    }
}
