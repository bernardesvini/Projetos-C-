using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSecao4._1
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string AprovadoReprovado(double notaFinale)
        {
            if (notaFinale >= 60.00)
                return "APROVADO";
            else
                return "REPROVADO";
        }

        public double FaltamPontos()
        {
            return 60.00 - NotaFinal();
        }

    }
}
