using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAula1505
{
    internal class MotorEletrico : IMotor
    {

        public double correnteEletrica;
        public bool ligado;
        public void Deligar()
        {
            if (ligado)
                ligado = false;

            Console.WriteLine("Motor elétrico desligado!");
        }

        public void Ligar()
        {
            if (correnteEletrica > 0 && !ligado)
            {
                ligado = true;
            }
            Console.WriteLine("Motor elétrico ligado!");
        }
    }
}
