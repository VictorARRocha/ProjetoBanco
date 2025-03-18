using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(string titular, int numeroConta, double saldo) : base(titular, numeroConta, saldo)
        {
        }
        public override double Depositar(double valor)
        {
            return Saldo += valor + (valor * 0.005);
        }

        public override string TipoConta()
        {
            return "Conta Poupança";
        }


    }
}
