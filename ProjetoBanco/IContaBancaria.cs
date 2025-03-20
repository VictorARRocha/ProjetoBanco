using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    public interface IContaBancaria
    {
        public  double Sacar(double valor);
        public double Depositar(double valor);
        public void ExibirSaldo();



    }
}
