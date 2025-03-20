using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class ContaBancaria : IContaBancaria
    {
        private string _titular;
        private int _numeroConta;
        private double _saldo;

        public string Titular
        {
            get
            {
                return _titular;

            }
            set
            {
                 _titular = value;
                
            }
        }
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0 || value == null)
                {
                    _saldo = 0;
                }
                else
                {
                    _saldo = value;
                }
            }
        }
        public int NumeroConta
        {
            get
            {
                return _numeroConta;
            }
            set
            {
                
                    _numeroConta = value;
                

            }
        }


        public ContaBancaria(string titular, int numeroConta, double saldo)
        {
            Titular = titular;
            NumeroConta = numeroConta;
            Saldo = saldo;
        }

        public virtual double Depositar(double valor)
        {
           return Saldo += valor;
        }
        public virtual double Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                return Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
                return Saldo;
            }


        }
        public virtual void ExibirSaldo()
        {
            Console.WriteLine($"Conta bancaria - {this.Titular} | Saldo: R${Saldo}");
            

        }




    }
}
