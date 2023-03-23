using System.Globalization;

namespace ExerciciosSecao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person();
            //Person person2 = new Person();  

            //Console.WriteLine("Insira os dados da primera pessoa");
            //Console.Write("Nome: ");
            //person1.name = Console.ReadLine();
            //Console.Write("Idade: ");
            //person1.age = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Insira os dados da segunda pessoa");
            //Console.Write("Nome: ");
            //person2.name = Console.ReadLine();
            //Console.Write("Idade: ");
            //person2.age = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine();

            //if (person1.age > person2.age)
            //    Console.WriteLine("A pessoa mais velha é " + person1.name);
            //else
            //    Console.WriteLine("A pessoa mais velha é " + person2.name);

            Worker worker1 = new Worker();
            Worker worker2 = new Worker();

            Console.WriteLine("Insira os dados do primero funcionário");
            Console.Write("Nome: ");
            worker1.name = Console.ReadLine();
            Console.Write("Salário: ");
            worker1.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Insira os dados do segundo funcionário");
            Console.Write("Nome: ");
            worker2.name = Console.ReadLine();
            Console.Write("Salário: ");
            worker2.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine();

            double salaryMed = (double)(worker1.salary + worker2.salary) / 2.0;
            Console.WriteLine("O salário médio é " + salaryMed.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}