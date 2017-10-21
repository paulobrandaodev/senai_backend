using System;

namespace while1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 1;
            int valor = 0;
            
            Console.WriteLine("Digite um valor para a tabuada: ");
            valor = Int16.Parse(Console.ReadLine());                  

            while(m <=10){
                Console.WriteLine(valor +" x "+ m +" = " +(valor * m));
                m++;
            }
        }
    }
}
