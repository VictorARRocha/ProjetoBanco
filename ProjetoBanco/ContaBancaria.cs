using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public class ContaBancaria
    {

        private int _numeroConta;
        private string _titular;
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
                    CriarNome();
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
                if (value < 0 || value == null  )
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
                    CriarNumero();
                }
                else
                {
                    _numeroConta = value; 
                }
                
            }
        }

    
        public void CriarConta()
        {
            CriarNumero();
            CriarNome();
            CriarSaldo();

        }
        public void CriarNome()
        {
            Console.WriteLine("Digite o nome do titular da conta");
            Titular = Console.ReadLine();

        }
        public void CriarNumero()
        {
            Console.WriteLine("Digite o número da conta");
            try { 
            NumeroConta = int.Parse(Console.ReadLine());
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Valor inválido");
                NumeroConta = 0;
            }

        }
        public void CriarSaldo()
        {
            try
            {
                Console.WriteLine("Digite o saldo da conta");
                Saldo = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Saldo = 0;
            }
            

        }

    }




       




    
}
