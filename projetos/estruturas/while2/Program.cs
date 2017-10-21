using System;
using System.IO;
using System.Text;

namespace while2
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader ler = new StreamReader("texto.txt",Encoding.Default);
            //Console.WriteLine(ler.ReadToEnd());
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");

            string texto = "";
            while( (texto = ler.ReadLine()) !=null){
                Console.WriteLine(texto);
            }

            ler.Close();
            

            /* string opcao = "";
            while(opcao != "sair"){
            
            Console.WriteLine(
                "Digite uma das opções abaixo : \n" +
                "-> Soma \n"+
                "-> Subtrair \n"+
                "-> Multiplicar \n"+
                "-> Dividir \n"+
                "-> Sair \n"
            );

            opcao = Console.ReadLine().ToLower();
            Console.Clear();

             if(opcao == "sair"){
                 Console.WriteLine("Deslogado! \n");
             }else{
                switch(opcao){
                    case "soma":
                    Console.WriteLine("Você fez uma soma! \n");
                    break;

                    case "subtrair":
                    Console.WriteLine("Você fez uma subtração! \n");
                    break;

                    case "multiplicar":
                    Console.WriteLine("Você fez uma multiplicação! \n");
                    break;

                    case "dividir":
                    Console.WriteLine("Você fez uma divisão! \n");
                    break;

                    default:
                    Console.WriteLine("Informação não listada :( \n");
                    break;
                }
                
              }
             

            } */


        }
    }
}
