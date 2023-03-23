using System.Globalization;

namespace ExercicioSecao6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(' ');
            int linhas = int.Parse(size[0]);
            int colunas = int.Parse(size[1]);

            int[,] array = new int[linhas, colunas];
            
            for (int i = 0; i < linhas; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < colunas; j++)
                {
                    array[i, j] = int.Parse(valores[j]);
                }
            }

            int numberFind = int.Parse(Console.ReadLine());

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (array[i, j] == numberFind)
                    {
                        Console.WriteLine("Position: " + i + ", " + j);
                        if (i != 0)
                            Console.WriteLine("Up: " + array[i - 1 ,j]);
                        if (j != 0)
                            Console.WriteLine("Left: " + array[i, j - 1]);
                        if (j < colunas -1)
                            Console.WriteLine("Right: " + array[i, j + 1]);
                        if (i < linhas -1)
                            Console.WriteLine("Down: " + array[i + 1, j]);
                    }
                }
            }

        }
    }
}