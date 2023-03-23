using System.Globalization;

namespace ExercicioSecao6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered: ");
            int qteEmployee = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= qteEmployee; i++)
            {
                Employee employee = new Employee();
                // criar construtor CARAIO
                Console.WriteLine("Employee #" + (i));
                Console.Write("ID: ");
                employee.Id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                employee.Name = Console.ReadLine();

                Console.Write("Salary: ");
                employee.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(employee);
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idToIncrease = int.Parse(Console.ReadLine());
            bool findMatch = false;


            foreach (Employee employee in employees)
            {
                if (employee.Id == idToIncrease)
                {
                    Console.Write("Enter the percentage: ");
                    employee.increaseSalary(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                    findMatch = true;
                }
            }

            if (findMatch == false)
                Console.WriteLine("This ID does not exists!");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Updated list of emplooyes:");

            foreach (Employee employee in employees)
                Console.WriteLine(employee);

        }
    }
}