using System;

namespace desconto
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto;
            double preco, taxa, resultado, acrescimo;
            Console.WriteLine("Programa de cálculo de desconto");
            Console.WriteLine("-------------------------------");
            
            Console.Write("Digite o nome do produto:");
            produto = Console.ReadLine();
            Console.WriteLine("-------------------------------");
           
            Console.Write("Digite o preço do produto:");
            preco = Double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            Console.Write("Digite a taxa de acréscimo:");
            taxa = Double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            acrescimo = preco*(taxa/100);
            resultado = preco + (preco*(taxa/100));

            Console.Clear();
            Console.WriteLine("Produto: "+produto.ToUpper());
            Console.WriteLine("Preço R$ : "+preco);
            Console.WriteLine("Taxa : "+taxa+"%");
            Console.WriteLine("Acrescimo R$ : "+acrescimo);
            Console.WriteLine("Valor final: R$ "+resultado);
        }
    }
}
