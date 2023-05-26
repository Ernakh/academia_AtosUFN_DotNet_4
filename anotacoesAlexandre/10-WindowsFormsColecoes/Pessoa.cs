using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_WindowsFormsColecoes
{
    internal class Pessoa : IComparable
    {
        public string Nome { get; set; }
        public DateOnly DataNascimento { get; set; }

        public Pessoa(string nome, DateOnly dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public override string ToString()
        {
            return "Nome: " + Nome  + ". Data Nascimento: " + DataNascimento;
        }

        public override bool Equals(object? obj)
        {
            return obj is Pessoa pessoa &&
                   Nome == pessoa.Nome &&
                   DataNascimento.Equals(pessoa.DataNascimento);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, DataNascimento);
        }

        public int CompareTo(object? obj)
        {
            Pessoa p = (Pessoa)obj;
            if (this.Nome == p.Nome)
            {
                return 0;
            }
            else if (this.Nome.CompareTo(p.Nome) < 0)
            {
                return -1;
            }
            return 1;
        }
    }
}
