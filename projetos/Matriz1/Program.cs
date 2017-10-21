using System;
using NetOffice.ExcelApi;

namespace Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] sacola = {
                {"id" ,"produto" ,"preco"},
                {"54" ,"Calça"   ,"R$ 100,00"},
                {"105","Blusa"   ,"R$ 56,00"}
            };

            // Para manipular o excel, vamos fazer uma referência a classe Aplication
            Application ex = new Application();

            // Abre o Excel
            ex.Visible = true;

            //Adiciona uma planilha em branco
            ex.Workbooks.Add();

            //Seleciona a 1º célula
            ex.Range("A1").Select();



            for(int lin = 0; lin < sacola.GetLength(0); lin++){
                for(int col = 0; col < sacola.GetLength(1); col++){
                    ex.Cells[lin+1,col+1].Value=sacola[lin,col];
                }                
            }

            //Salvar o arquivo de excel
            ex.ActiveWorkbook.SaveAs("produtos.xls");

            //Fechar Excel
            ex.Quit();

        }
    }
}
