using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = {12 , 5 , 51 , 8 , 1 , 0 , 7 , 11};
            int rs = 0;
            int media = 0;

            for(int i = 0; i < n.Length; i++){
                rs += n[i];
            }
            media = rs/n.Length;
            Console.WriteLine("Soma: "+rs);
            Console.WriteLine("Média: "+media);
        }
    }
}
