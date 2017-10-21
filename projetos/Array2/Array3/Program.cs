using System;

namespace Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as cores separadas por vírgula: ");
            string[] cores = Console.ReadLine().Split(',');

            for(int t =0; t < cores.Length; t++){
                Console.WriteLine("Você digitou a cor: "+cores[t]);
            }

        }
    }
}
