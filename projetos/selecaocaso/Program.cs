using System;

namespace selecaocaso
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Paulo";
            Console.WriteLine(nome.Substring(0,1).ToLower()+nome.Substring(1,4).ToUpper());

        }
    }
}
