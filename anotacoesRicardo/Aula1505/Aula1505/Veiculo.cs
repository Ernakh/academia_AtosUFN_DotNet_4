using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1505
{
    internal class Veiculo
    {
        public string _modelo;
        public double _potencia;


        public virtual void Ligar() 
        {
            Console.WriteLine("Oi, sou o veiculo ligado!");
        }
    }
}
