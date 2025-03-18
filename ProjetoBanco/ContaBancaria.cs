using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class ContaBancaria
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
                if (value == null || value == "")
                {
                    Console.Clear();
                    Console.WriteLine("Digite um nome válido");
                }
                else
                {
                    _titular = value;
                }
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
                if (value.ToString().Length < 8)
                {
                    Console.Clear();
                    Console.WriteLine("O número da conta precisa ter mais de oito caracteres.");
                }
                else
                {
                    _numeroConta = value;
                }

            }
        }


        public ContaBancaria(string titular, int numeroConta, double saldo)
        {
            _titular = titular;
            _numeroConta = numeroConta;
            _saldo = saldo;
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
        public void ExibirSaldo()
        {
            Console.WriteLine($"{TipoConta()} - {this.Titular} | Saldo: R${Saldo}");
            

        }

        public virtual string TipoConta()
        {
            return "rodolfo"; 
        }







    }
}
