using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ListaOrdenada
{
    internal class Pessoa : IComparable {
        public int codigo;
        public string nome;
        public Pessoa(int codigo, string nome) {
            this.codigo = codigo;
            this.nome = nome;
        }
        public int CompareTo(object? obj) {
            Pessoa p = (Pessoa)obj;
            if (this.nome == p.nome)
            {
                return 0;
            } else if (this.nome.CompareTo(p.nome) < 0) //criterio de ordenacao
            {
                return -1;
            }
            return 1;
        }
    }

}