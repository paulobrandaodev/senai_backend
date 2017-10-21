using System;

namespace desvio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração da variável notaaluno
            double notaaluno;

            /*
            Vamos requisitar a nota ao usuário e guardar na variável 
            notaaluno
             */

             Console.WriteLine("Digite a nota do aluno: ");
             notaaluno = double.Parse(Console.ReadLine());


            /*Se o aluno tiver uma nota maior ou igual à 7
             ele estará aprovado, caso contrário estará reprovado
             */

             /*
             if(notaaluno >= 7){
                 Console.WriteLine("Aprovado");   
             }else{
                 Console.WriteLine("Reprovado");
             }
             */

             /*
             Se o aluno tiver uma nota maior ou igual a 7
             então ele estará aprovado, caso o aluno tenha 
             uma nota menor ou igual 4 ele estará reprovado
             caso contrário ele estará em recuperação
             */

             if(notaaluno >= 7){
                 Console.WriteLine("Aprovado");
             }else if(notaaluno <= 4){
                 Console.WriteLine("Reprovado");
             }else{
                 Console.WriteLine("De Recuperação");
             }

        }
    }
}
