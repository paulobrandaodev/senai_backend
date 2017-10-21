using System;

namespace FCRSA
{
    class Program
    {
        static void Main(string[] args)
        {   
            double[] valores = {2.5,4.8,57.45,57,1,45,45}; 
            Console.WriteLine(Media(valores));
        }

        /// <summary>
        /// A runção mensagem retorna uma mensagemd e boa noite 
        /// </summary>
        /// <returns>Olá, boa noite</returns>
        static string Mensagem(){
            return "Olá, boa noite";
        }

        /// <summary>
        /// Imprime a média
        /// </summary>
        /// <param name="v">Array de doubles</param>
        /// <returns>Média</returns>
        static double Media(double[] v){
            double rs = 0;
            for(int i =0; i < v.Length; i++){
                rs +=v[i];
            }
            return rs/v.Length;

        }

    }
}
