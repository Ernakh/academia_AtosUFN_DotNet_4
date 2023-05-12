using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Arquivo
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Email  { get; set; }
        public string DataNascimento { get; set; }

        public Pessoa(string nome, string email, string dataNascimento) 
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }

        public Pessoa(string nome, string dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Email = gerarEmail();
        }

        public string gerarEmail()
        {
            return "";
        }

        public override string ToString()
        {
            return Nome + " : " + Email;
        }
    }
}
