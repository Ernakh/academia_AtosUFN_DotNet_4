using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1505
{
    public class Cavalo : Animal
    {
        public string Raca { get; set; }
        public Cavalo(string nome, int idade, string raca) : base(nome, idade)
        {
            Raca = raca;
        }

        public override void emitirSom()
        {
            Console.WriteLine("O "+this.Nome+" está relinchando!");
        }


    }
}
