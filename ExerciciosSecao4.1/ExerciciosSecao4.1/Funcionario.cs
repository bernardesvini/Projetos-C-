using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSecao4._1
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void  AumentarSalario(double porcentagem)
        {
            double salarioAumentado = porcentagem / 100;

            SalarioBruto += SalarioBruto * salarioAumentado;
        }
    }
}
