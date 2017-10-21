using System;

namespace cargos
{
    class Program
    {
        static void Main(string[] args)
        {
            string cargos;
            Console.WriteLine("Digite um cargo: ");
            cargos = Console.ReadLine().ToLower();

        switch(cargos){
            case "diretor":
            Console.WriteLine("R$ 15.000,00");
            break;

            case "gerente":
            Console.WriteLine("R$ 12.000,00");
            break;

            case "analista":
            Console.WriteLine("R$ 8.000,00");
            break;

            case "assistente":
            Console.WriteLine("R$ 4.000,00");
            break;

            case "auxiliar":
            Console.WriteLine("R$ 2.000,00");
            break;

            default:
            Console.WriteLine("Não há salário");
            break;       

        }


        }
    }
}
