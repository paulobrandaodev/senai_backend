using System;

namespace primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            Console.Clear();
            Console.WriteLine("Programa de boas vindas");
            Console.Write("Digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Olá "+ nome.ToUpper());
            Console.WriteLine("Digite sua idade:");
            idade = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Você tem "+idade+" anos");
        }
    }
}
