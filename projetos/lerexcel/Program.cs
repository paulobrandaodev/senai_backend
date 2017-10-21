using System;
using NetOffice.ExcelApi;

namespace lerexcel
{
    class Program
    {
        static void Main(string[] args)
        {
            Application ex = new Application();
            // ex.Visible = true; // Abrir o excel
            ex.Workbooks.Open("produtos.xls");
            ex.Range("A1").Select();

            string[,] dados = new string[3,3];

            for(int lin = 0; lin < 3; lin++){
                for(int col = 0; col <3; col++){
                    dados[lin,col] = ex.Cells[lin+1,col+1].Value.ToString();
                }
            }

            ex.Quit();

            for(int lin = 0; lin < 3; lin++){
                for(int col = 0; col <3; col++){
                    Console.Write(dados[lin,col]+"\t");
                }
                Console.WriteLine();
            }
            
        }
    }
}
