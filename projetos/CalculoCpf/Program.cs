using System;

namespace CalculoCpf
{
    class Program
    {
        static void Main(string[] args)
        {
          
          Console.WriteLine("Digite seu CPF: ");
          string cpf = Console.ReadLine();
          
          if(ValidaCPF(cpf))
            Console.WriteLine("Válido");
            else
            Console.WriteLine("Inválido");      
        }


        /// <summary>
        /// Função para validação de CPF
        /// </summary>
        /// <param name="cpfUsuario">CPF sem pontuação</param>
        /// <returns>Verdadeiro ou falso</returns>
        static bool ValidaCPF(string cpfUsuario){

            bool retorno = true;
            string cpfCalculo = "";
            
            int[] v1 = {10,9,8,7,6,5,4,3,2};
            int[] v2 = {11,10,9,8,7,6,5,4,3,2};

            int resultado = 0;
            int resto = 0;

            cpfCalculo = cpfUsuario.Substring(0,9);

            //Validando 1° dígito
            for(int i = 0; i < cpfCalculo.Length; i++){
                resultado += Int16.Parse(cpfCalculo[i].ToString())*v1[i];
            }

            resto = resultado % 11;
            if(resto < 2){
                cpfCalculo += "0";
            }else{
             cpfCalculo += (+11-resto).ToString();
            }

            //Zerando as variáveis para 2° dígito
            resultado = 0;
            resto = 0;

            //Validando 2° dígito
            for(int j = 0; j < cpfCalculo.Length; j++){
                resultado += Int16.Parse(cpfCalculo[j].ToString())*v2[j];
            }

            resto = resultado % 11;
            if(resto < 2){
                cpfCalculo += "0";
            }else{
             cpfCalculo += (+11-resto).ToString();
            }

            if(cpfUsuario != cpfCalculo)
                retorno = false;
            
           return retorno;
        }


    }
}
