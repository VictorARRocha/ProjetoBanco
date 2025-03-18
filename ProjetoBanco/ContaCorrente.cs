using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(string titular, int numeroConta, double saldo) : base(titular, numeroConta, saldo)
        {
        }
        public override double Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                return Saldo -= valor + 5;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
                return Saldo;
            }


        }

        public override string TipoConta() 
        {
            return "Conta Corrente";
        }

    }
}
