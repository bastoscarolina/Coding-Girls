using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    internal class Aluno
    {
        public string nome = string.Empty;
        public string matricula  = string.Empty;
        public double notaProva1;
        public double notaProva2;
        public double notaTrabalho;

        public double calculaNotaFinal(double prova1, double prova2, double trabalho)
        {
            double mediaDeAprovacao = 7.0;
            double notaFinal = 4 * mediaDeAprovacao - prova1 - prova2 - trabalho;
            return notaFinal;
        }

        public double calculaMedia(double prova1, double prova2, double trabalho)
        {
            double media = (prova1 + prova2 + trabalho) / 3;
            return media;
        }
    }
}
