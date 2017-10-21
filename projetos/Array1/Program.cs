using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cidades = {
                "Curitiba",
                "Vitória",
                "Salvador",
                "Leme",
                "Campinas",
                "São Paulo"
            };
            for(int r=0; r < cidades.Length; r++ )
             Console.WriteLine(cidades[r]);
        }
        
    }
}
