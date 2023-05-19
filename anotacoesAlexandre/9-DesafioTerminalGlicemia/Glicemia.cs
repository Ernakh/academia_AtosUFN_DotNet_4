using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_DesafioTerminalGlicemia
{
    internal class Glicemia : IComparable {
        public int valor;
        public string data;

        public Glicemia(string data, int valor) {
            this.valor = valor;
            this.data = data;
        }

         public override string ToString()
        {
            return data + " - " + valor;
        }

        public int CompareTo(object? obj) {
            Glicemia g = (Glicemia)obj;
            if (this.valor == g.valor)
            {
                return 0;
            } else if (this.valor < g.valor) //criterio de ordenacao
            {
                return -1;
            }
            return 1;
        }
    }

}