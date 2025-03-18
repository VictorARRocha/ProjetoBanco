namespace ProjetoBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ContaCorrente cC = new ContaCorrente("Victor Rocha", 182363423, 1000);
            ContaPoupanca cP = new ContaPoupanca("João Eduardo", 214723617, 2000);

            cC.ExibirSaldo();
            cP.ExibirSaldo();

            cC.Depositar(500);
            cP.Depositar(1000);

            Console.WriteLine();
            cC.ExibirSaldo();
            cP.ExibirSaldo();

            cC.Sacar(200);
            cP.Sacar(500);

            Console.WriteLine();
            cC.ExibirSaldo();
            cP.ExibirSaldo();
        }
    }
}