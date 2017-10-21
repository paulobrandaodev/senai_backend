using System;

namespace dowhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            int aumento = 0;

            do{
                Console.WriteLine("O aumento é igual a : " + aumento);
                aumento += 50;
            }while(aumento <= 500);
        }
    }
}
