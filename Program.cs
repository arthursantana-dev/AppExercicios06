using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppExercicios06
{
    internal class Program
    {
        static void ExemploWhile()
        {
            string resposta = "S";
            double valor, total = 0;

            while(resposta == "S")
            {
                Console.WriteLine("Informe um valor: ");
                valor = float.Parse(Console.ReadLine());

                total += valor;

                Console.WriteLine("Deseja adicionar mais? (S/N)");
                resposta = Console.ReadLine().ToUpper();
            }

            Console.WriteLine($"O valor final é: {total}");
        }

        static void OperacoesSaldo()
        {
            Console.WriteLine("Valor inicial: ");
            double saldoInicial = double.Parse(Console.ReadLine());
            string respostaCliente = "S";

            Console.WriteLine("Digite S para sacar, D para depositar e X para sair");
            respostaCliente = Console.ReadLine().ToUpper();

            while (respostaCliente != "X")
            {
                
                if (respostaCliente == "X") break;

                switch (respostaCliente)
                {
                    case "S":
                        Console.WriteLine("Insira o valor a ser sacado: ");
                        double valorSaque = double.Parse(Console.ReadLine());

                        while (valorSaque > saldoInicial)
                        {
                            Console.WriteLine($"Valor de saque maior que {saldoInicial.ToString("C")}");
                            valorSaque = double.Parse(Console.ReadLine());
                        }

                        saldoInicial -= valorSaque;
                        Console.WriteLine($"Você sacou {valorSaque.ToString("C")} reais");
                        break;

                    case "D":
                        Console.WriteLine("Insira o valor a ser depositado: ");
                        double valorDeposito = double.Parse(Console.ReadLine());
                        saldoInicial += valorDeposito;
                        break;
                }

                Console.WriteLine("Deseja fazer qual operação? (S,D,X)");
                respostaCliente = Console.ReadLine().ToUpper();
            }
        }

        static void MatriculaCursos()
        {
            Console.WriteLine("Qual operação deseja fazer? M matrícula, X sair");
            string respostaUsuario = Console.ReadLine();

            string[] alunosDesenvolvimento = {};
            string[] alunosAdministracao = { };
            string[] alunosMecatronica = { };


            while (respostaUsuario != "X")
            {
                Console.WriteLine("Qual curso deseja fazer a matrícula? D Desenvolvimento, A Administração, M Mecatrônica");
                string opcaoCursoMatricula = Console.ReadLine().ToUpper();

                switch (opcaoCursoMatricula)
                {
                    case "D":
                        if (alunosDesenvolvimento.Length >= 5)
                        {
                            Console.WriteLine("Curso lotado!");
                        } else
                        {
                            Console.WriteLine("insira o nome do aluno:");
                            string nomeAluno = Console.ReadLine();
                            alunosDesenvolvimento =  alunosDesenvolvimento.Append(nomeAluno).ToArray();
                        } 
                        break;

                    case "A":
                        if (alunosAdministracao.Length >= 5)
                        {
                            Console.WriteLine("Curso lotado!");
                        }
                        else
                        {
                            Console.WriteLine("insira o nome do aluno:");
                            string nomeAluno = Console.ReadLine();
                            alunosAdministracao = alunosAdministracao.Append(nomeAluno).ToArray();
                        }
                        break;

                    case "M":
                        if (alunosMecatronica.Length >= 5)
                        {
                            Console.WriteLine("Curso lotado!");
                        }
                        else
                        {
                            Console.WriteLine("insira o nome do aluno:");
                            string nomeAluno = Console.ReadLine();
                            alunosMecatronica = alunosMecatronica.Append(nomeAluno).ToArray();
                        }
                        break;
                }

                

                int totalMatriculas = alunosAdministracao.Length + alunosMecatronica.Length + alunosDesenvolvimento.Length;
                Console.WriteLine($"Total de Matrículas: {totalMatriculas}");

                Console.WriteLine("Qual operação deseja fazer? M matrícula, X sair");
                respostaUsuario = Console.ReadLine().ToUpper();
            }
        }

        static void VendaDevolucaoCliente()
        {
            double contaAReceberCliente = 0;

            Console.WriteLine("Operação: ");
            string operacao = Console.ReadLine().ToUpper();
            double valorTotal = 0;

            do
            {
                Console.WriteLine("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine("Valor Unitário: ");
                double valorUnitario = double.Parse(Console.ReadLine());

                valorTotal = valorUnitario * quantidade;

                switch (operacao)
                {
                    case "V":

                        contaAReceberCliente += valorTotal;

                        break;

                    case "D":

                        contaAReceberCliente -= valorTotal;
                        break;
                }

                Console.WriteLine(Math.Abs(contaAReceberCliente).ToString("C"));

                Console.WriteLine("Operação: ");
                operacao = Console.ReadLine().ToUpper();

            } while (operacao != "X");

            string AReceberOuAPagar = contaAReceberCliente < 0? "a receber" : "a pagar";

            Console.WriteLine($"{Math.Abs(contaAReceberCliente).ToString("C") } {AReceberOuAPagar}");
        }

        static void Main(string[] args)
        {
            //ExemploWhile();
            //OperacoesSaldo();
            //MatriculaCursos();
            VendaDevolucaoCliente();
            Console.ReadKey();
        }
    }
}
