using System;

namespace Array4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma sequência de números, separados por vírgula: ");
            string[] numeros = Console.ReadLine().Split(',');
            int rs =0;

            /* for(int i =0; i < numeros.Length; i++){
                rs += Int32.Parse(numeros[i]);
            } */

            foreach(var i in numeros){
                rs += Int32.Parse(i);
            }

            Console.WriteLine("Soma: "+rs);
            Console.WriteLine("Média: "+(rs/numeros.Length));
        }
    }
}
