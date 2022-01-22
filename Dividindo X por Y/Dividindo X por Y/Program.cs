using System;

namespace Dividindo_X_por_Y
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga os valores");
            int limit = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                double X = double.Parse(line[0]);
                double Y = double.Parse(line[1]);

                Console.WriteLine((Y == 0) ? "divisao impossivel" : $"{(X / Y).ToString("N1")}");

            }
        }
    }
}
