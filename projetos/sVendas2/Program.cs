using System;
using System.IO;
using NetOffice.ExcelApi;

namespace sVendas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            Application excel = new Application();

            FileInfo cadCliente = new FileInfo(@"cadCliente.xlsx");
            FileInfo cadProduto = new FileInfo(@"cadProduto.xlsx");
            FileInfo cadVenda   = new FileInfo(@"cadVenda.xlsx");


            while (opcao != 9)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Vendas");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Digite uma das operações abaixo:");
                Console.WriteLine("1 - Cadastro de Clientes\n2 - Cadastro de Produtos\n3 - Cadastro de Vendas\n4 - Extrato do Cliente\n9 - Sair");
                opcao = Int16.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Digite o nome do cliente:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o email do cliente");
                        string email = Console.ReadLine();
                        Console.WriteLine("Digite o CPF ou CNPJ");
                        string pessoa = Console.ReadLine().ToLower();
                        if (cadCliente.Exists)
                        {

                            excel.Workbooks.Open(@"cadCliente.xlsx");
                            excel.Range("A1").Select();
                            for (int i = 1; i < 1000; i++)
                            {
                                if (excel.Range("A" + i).Value == null)
                                {
                                    excel.Range("A" + i).Value = nome;
                                    excel.Range("B" + i).Value = email;
                                    excel.Range("C" + i).Value = pessoa;
                                    excel.Range("D" + i).Value = DateTime.Now.ToShortDateString();
                                    excel.ActiveWorkbook.Save();
                                    break;
                                }
                            }
                        }
                        else
                        {
                            excel.Workbooks.Add();
                            excel.Range("A1").Select();
                            excel.Range("A1").Value = "Nome";
                            excel.Range("B1").Value = "E-mail";
                            excel.Range("C1").Value = "CPF/CNPJ";
                            excel.Range("D1").Value = "Data de Cadastro";

                            excel.Range("A2").Value = nome;
                            excel.Range("B2").Value = email;

                            excel.Range("C2").Value = pessoa;
                            excel.Range("D2").Value = DateTime.Now.ToShortDateString();


                            excel.ActiveWorkbook.SaveAs(@"cadCliente.xlsx");
                        }

                        excel.Quit();
                        break;


                    case 2:

                        Console.WriteLine("Digite o código do produto:");
                        string codigo = Console.ReadLine();
                        Console.WriteLine("Digite o nome do produto");
                        string produto = Console.ReadLine();
                        Console.WriteLine("Digite a descrição do produto");
                        string descricao = Console.ReadLine().ToLower();
                        Console.WriteLine("Digite o preço do produto");
                        string preco = Console.ReadLine().ToLower();
                        if (cadProduto.Exists)
                        {

                            excel.Workbooks.Open(@"cadProduto.xlsx");
                            excel.Range("A1").Select();
                            for (int i = 1; i < 1000; i++)
                            {
                                if (excel.Range("A" + i).Value == null)
                                {
                                    excel.Range("A" + i).Value = codigo;
                                    excel.Range("B" + i).Value = produto;
                                    excel.Range("C" + i).Value = descricao;
                                    excel.Range("D" + i).Value = preco;
                                    excel.Range("D" + i).Value = DateTime.Now.ToShortDateString();
                                    excel.ActiveWorkbook.Save();
                                    break;
                                }
                            }
                        }
                        else
                        {
                            excel.Workbooks.Add();
                            excel.Range("A1").Select();
                            excel.Range("A1").Value = "Código";
                            excel.Range("B1").Value = "Produto";
                            excel.Range("C1").Value = "Descrição";
                            excel.Range("D1").Value = "Preço";
                            excel.Range("E1").Value = "Data de Cadastro";

                            excel.Range("A2").Value = codigo;
                            excel.Range("B2").Value = produto;
                            excel.Range("C2").Value = descricao;
                            excel.Range("D2").Value = preco;
                            excel.Range("E2").Value = DateTime.Now.ToShortDateString();


                            excel.ActiveWorkbook.SaveAs(@"cadProduto.xlsx");
                        }

                        excel.Quit();
                        break;


                } 
                     
                 }
                }
            }
        }
