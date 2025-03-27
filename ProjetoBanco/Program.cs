using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ProjetoBanco
{
    public class Program
    {
        static void Main(string[] args)
        {
            try 
            {
            List<ContaBancaria> contaBancarias = new List<ContaBancaria>();

            ContaCorrente cC = new ContaCorrente("Victor de Arruda", 242, 1000);
            contaBancarias.Add(cC);







            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("__________________________________");
            Console.WriteLine("        Sistema bancário          ");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            Console.WriteLine("Digite: ");
            Console.WriteLine("1 - Criar nova conta");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Depositar ");
            Console.WriteLine("4 - Exibir saldo ");
            Console.WriteLine("Qualquer outra coisa para sair");
            string opc = Console.ReadLine();


            int continua = 0;
                while (continua == 0)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("__________________________________");
                    Console.WriteLine("        Sistema bancário          ");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("Digite: ");
                    Console.WriteLine("1 - Criar nova conta");
                    Console.WriteLine("2 - Sacar");
                    Console.WriteLine("3 - Depositar ");
                    Console.WriteLine("4 - Exibir saldo ");
                    Console.WriteLine("Qualquer outra coisa para sair");
                    opc = Console.ReadLine();

                    switch (opc)
                    {
                        case "1":
                            CriarConta(contaBancarias);
                            break;

                        case "2":
                            Sacar(contaBancarias);
                            break;

                        case "3":
                            Depositar(contaBancarias);
                            break;

                        case "4":
                            MostrarSaldo(contaBancarias);
                            break;

                        default:
                            Console.WriteLine("Sistema encerrado.");
                            break;
                    }

                    Console.WriteLine("Você deseja continuar?");
                    Console.WriteLine("0 - Sim | 1 - Não");
                    continua = int.Parse(Console.ReadLine());
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Insira o formato de dado correto.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }


        }

        public static void CriarConta(List<ContaBancaria> contaBancarias)
        {
            try
            {
                Console.WriteLine("Digite o nome do titular");
                string nomeUser = Console.ReadLine();

                Random random = new Random();
                int numeroConta = random.Next(100,999);
                foreach (var i in contaBancarias)
                {
                    if (numeroConta == i.NumeroConta)
                    {
                        random.Next(100, 999);
                    }
                }

                Console.WriteLine("Digite o Saldo da conta");
                double saldo = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual o tipo da sua nova conta");
                Console.WriteLine("1 - Poupança");
                Console.WriteLine("2 - Corrente");
                int opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    ContaPoupanca cP = new ContaPoupanca(nomeUser, numeroConta, saldo);
                    contaBancarias.Add(cP);
                }
                else if (opc == 2)
                {
                    ContaCorrente cC = new ContaCorrente(nomeUser, numeroConta, saldo);
                    contaBancarias.Add(cC);
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                    CriarConta(contaBancarias);
                }

            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
            
            }

        public static void MostrarContas(List<ContaBancaria> contaBancarias)
        {
            try
            {
                foreach(var i  in contaBancarias)
                {
                    Console.WriteLine($"Conta N {i.NumeroConta} - Titular: {i.Titular}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static bool ProcurarContas(int num, List<ContaBancaria> contaBancarias)
        {

                foreach (var i in contaBancarias)
                {
                    if (num == i.NumeroConta)
                    {
                        return true;
                    }
                }
                return false;

            
        }

        public static void Sacar(List<ContaBancaria> contaBancarias)
        {
            try
            {
                Console.WriteLine("Escolha a conta em que você deseja sacar: ");
                MostrarContas(contaBancarias);
                Console.WriteLine("Numero da conta: ");
                int opc = int.Parse((Console.ReadLine()));
                ProcurarContas(opc, contaBancarias);
                if (ProcurarContas(opc, contaBancarias))
                {
                    ContaBancaria conta = contaBancarias.FirstOrDefault(c => c.NumeroConta == opc);
                    Console.WriteLine("Quanto você deseja sacar? ");
                    double sacar = double.Parse(Console.ReadLine());
                    conta.Sacar(sacar);
                }
                else
                {
                    Console.WriteLine("Conta inexistente");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }

        public static void MostrarSaldo(List<ContaBancaria> contaBancarias)
        {
            try
            {
                Console.WriteLine("Escolha a conta em que você deseja sacar: ");
                MostrarContas(contaBancarias);
                Console.WriteLine("Numero da conta: ");
                int opc = int.Parse((Console.ReadLine()));
                ProcurarContas(opc, contaBancarias);
                if (ProcurarContas(opc, contaBancarias))
                {
                    Console.WriteLine();
                    ContaBancaria conta = contaBancarias.FirstOrDefault(c => c.NumeroConta == opc);
                    conta.ExibirSaldo();
                }
                else
                {
                    Console.WriteLine("Conta inexistente");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            }   

        public static void Depositar(List<ContaBancaria> contaBancarias)
        {
            try
            {
                Console.WriteLine("Escolha a conta que deseja realizar o deposito");
                MostrarContas(contaBancarias);

                Console.WriteLine("Numero da conta: ");
                int opc = int.Parse((Console.ReadLine()));
                ProcurarContas(opc, contaBancarias);
                if (ProcurarContas(opc, contaBancarias))
                {
                    ContaBancaria conta = contaBancarias.FirstOrDefault(c => c.NumeroConta == opc);
                    Console.WriteLine("Quanto você deseja depositar? ");
                    double deposito = double.Parse(Console.ReadLine());
                    conta.Depositar(deposito);
                }
                else
                {
                    Console.WriteLine("Conta inexistente");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            }
    }   
}