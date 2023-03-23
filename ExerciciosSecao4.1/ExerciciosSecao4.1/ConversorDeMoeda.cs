using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSecao4._1
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double Converter(double cotacao, double qte)
        {
            return (cotacao * qte) + (cotacao * qte * Iof);
        }
    }
}
