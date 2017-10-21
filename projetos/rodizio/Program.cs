using System;

namespace rodizio
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Digite a placa");
            string placa = Console.ReadLine();
            int caracteres = placa.Length;
            string final = placa.Substring(caracteres-1);

            if (final == "0" || final == "1"){
                Console.Write("Seu rodízio é na segunda");
            }else if(final == "2" || final == "3"){
                Console.Write("Seu rodízio é na terça");
            }else if(final == "4" || final == "5"){
                Console.Write("Seu rodízio é na quarta");
            }else if(final == "6" || final == "7"){
                Console.Write("Seu rodízio é na quinta");
            }else{
                Console.Write("Seu rodízio é na sexta");
            }
            
        }
    }
}
