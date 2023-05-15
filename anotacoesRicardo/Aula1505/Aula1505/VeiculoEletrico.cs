using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1505
{
    internal class VeiculoEletrico : Veiculo
    {
        public double _autonomia;

        public override void Ligar()
        {
            if (_autonomia > 0)
            {
                Console.WriteLine("Carro elétrico ligado");
            }
            else
            {
                Console.WriteLine("Não foi possivel ligar. Sem bateria");
            }
        }
        
        public void Carregar()
        {
            this._autonomia += 10;
            Console.WriteLine("Carreguei 10%");
        }


    }
}
