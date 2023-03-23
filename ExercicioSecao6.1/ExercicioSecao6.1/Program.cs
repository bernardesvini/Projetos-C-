namespace ExercicioSecao6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos quartos vão ser alugados: ");
            int qteQuartos = int.Parse(Console.ReadLine());

            Room[] rooms = new Room[10];

            Console.Clear();

            for (int i = 0; i < qteQuartos; i++)
            {
               
                Console.Write("Numero do quarto: ");
                int numberRoom = int.Parse(Console.ReadLine());

                rooms[numberRoom] = new Room();
                rooms[numberRoom].RoomNumber = numberRoom;

                Console.Write("Nome do inquilino: ");
                rooms[numberRoom].RenterName = Console.ReadLine();

                Console.Write("E-mail do inquilino: ");
                rooms[numberRoom].RenterEmail = Console.ReadLine();

                Console.WriteLine();
            }

            Console.WriteLine("Quartos alugados: ");
            
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                    Console.WriteLine(rooms[i]);
            }

        }
    }
}