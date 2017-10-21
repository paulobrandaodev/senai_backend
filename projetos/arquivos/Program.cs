using System;
using System.IO;

namespace arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para criar e escrever um arquivo nós vamos ultilizar o comando
            //ScreamWriter (é uma classe)
            StreamWriter ar = new StreamWriter("dados.txt", true);

            //Vamos ultilizar o fileinfo para ter informações sobre o arquivo
            //Atributos do FileInfo(criar, deletar, somente leitura, oculto...)
            FileInfo fi = new FileInfo("dados.txt");
            
            //A variável long foi criada para guardar o tamanho do arquivo 
            long peso1 = fi.Length;

            // para escrever no arquivo dados.txt, vamos usar
            // o comando Write ou WriteLine
            ar.WriteLine("Hoje é quinta-feira");
            ar.WriteLine("Amanhã é sexta-feira");

            // para criar o arquivo você precisa ultilizar o comando "Close"
            ar.Close();
            
            FileInfo fi2 = new FileInfo("dados.txt");
            //Vamos pegar o peso atual do arquivo
            long peso2 = fi2.Length;

            if (peso2 > peso1)
            {
                Console.WriteLine("Arquivo alterado com sucesso");
                Console.WriteLine("Peso inicial: "+peso1);
                Console.WriteLine("Peso atual: "+peso2);
            }
            else
            {
                Console.WriteLine("Não houve modificações no arquivo dados.txt");
            }

        }
    }
}
