using System;

namespace Xenlonguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga o valor");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                int qtdEsferas = int.Parse(Console.ReadLine());
                int contEsferas = 0;

                for (int j = 1; j <= qtdEsferas; j++)
                {
                    int contDivisores = 0;

                    for (int qtdEstrelas = 1; qtdEstrelas <= j; qtdEstrelas++)
                    {
                        if (j % qtdEstrelas == 0) contDivisores++;
                    }

                    if (contDivisores % 2 == 0)
                    {
                        contEsferas++;
                    }

                }

                Console.WriteLine(contEsferas);
            }
        }
    }
}
