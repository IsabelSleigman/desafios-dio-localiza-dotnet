using System;

namespace HO_HO_HO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga a quantidade desejada");
            int N = int.Parse(Console.ReadLine());

            //Exibir "Ho" do papai noel
            for (int i = 0; i < N; i++)
            {
                if (i < (N - 1))
                {
                    Console.Write("Ho ");
                }
                else
                {
                    Console.WriteLine("Ho!");
                }
            }
        }
    }
}
