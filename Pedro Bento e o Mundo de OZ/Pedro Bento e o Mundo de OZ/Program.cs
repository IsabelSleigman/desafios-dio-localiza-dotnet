using System;
using System.Collections.Generic;
using System.Linq;

namespace Pedro_Bento_e_o_Mundo_de_OZ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> joias = new List<string>();
            bool aindaTemJoias;

            do
            {
                Console.WriteLine("Informe o modelo da joia");
                var joia = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(joia))
                {
                    joias.Add(joia);
                    aindaTemJoias = true;
                }
                else
                {
                    aindaTemJoias = false;
                }
            } while (aindaTemJoias);

            Console.WriteLine(joias.Distinct().Count());
        }
    }
}
