using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*9 - Crie uma classe chamada ContaBancaria que tenha as propriedades 
 * NumeroConta, Titular, Saldo e Limite. Crie também
um método chamado Depositar, que recebe um valor e adiciona ao saldo da 
conta, e um método Sacar, que recebe um 
valor e verifica se o saldo é suficiente para a operação.*/
namespace Aua0905
{
    internal class ContaBancaria
    {
        private string _numeroConta;
        private string _titular;
        private double _saldo;
        private double _limite;

        public string NumeroConta { get; set; } 

        public string Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _titular = value.ToUpper();
                }
            }
        }
        public double Saldo
        {
            get { return _saldo; }
        }

        public double Limite
        {
            get { return _limite; }
            set
            {
                if(value > 0)
                {
                    _limite = value;
                }
            }
        }
        public void Depositar(double valDeposito)
        {
            if (valDeposito > 0)
            {
                _saldo += valDeposito; // _saldo = valDeposito + _saldo;
                Console.WriteLine("Deposito efetuado. Saldo atual: "+_saldo);
            }
            else
            {
                Console.WriteLine("Depósito não efetuado!");
            }
        }

        public bool Sacar(double valSaque)
        {
            if(valSaque <= (_saldo+Limite))
            {
                _saldo -= valSaque; // _saldo = _saldo - valSaque
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
