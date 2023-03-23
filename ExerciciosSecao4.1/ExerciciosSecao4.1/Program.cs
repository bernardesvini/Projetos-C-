using System.Globalization;

namespace ExerciciosSecao4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bem vindo ao programa de solução de Retangulos");
            //Console.ReadLine();
            //Console.Clear();

            //Retangulo retangulo = new Retangulo();

            //Console.Write("Indique a Largura do retângulo: ");
            //retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Indique a Altura do retângulo: ");
            //retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double area = retangulo.Area();
            //double perimetro = retangulo.Perimetro();
            //double diagonal = retangulo.Diagonal();

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("PERIMETRO = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("DIAGONAL = " + diagonal.ToString("F2", CultureInfo.InvariantCulture));

            //Console.ReadLine();


            // Exercicio 2
            //Funcionario funcionario = new Funcionario();

            //Console.Write("Nome: ");
            //funcionario.Nome = Console.ReadLine();

            //Console.Write("Salário Bruto: ");
            //funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Imposto: ");
            //funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Funcionário: " + funcionario.Nome + ", " + funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.Write("Digite a porcentagem para aumentar o salário: ");
            //funcionario.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            //Console.WriteLine("Dados Atualizados: " + funcionario.Nome + ", " + funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            //Exercicio 3

            //Aluno aluno = new Aluno();

            //Console.Write("Nome do Aluno: ");
            //aluno.Nome = Console.ReadLine();

            //Console.WriteLine("Digite as três notas do aluno");
            //aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine(aluno.AprovadoReprovado(aluno.NotaFinal()));
            //if (aluno.AprovadoReprovado(aluno.NotaFinal()) == "REPROVADO")
            //    Console.WriteLine("FALTARAM " + aluno.FaltamPontos().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");

            //Exercio Aula 48

            Console.Write("Qual a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar: ");
            double qte = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.Converter(cotacao, qte).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}