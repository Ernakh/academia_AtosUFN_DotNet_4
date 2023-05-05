using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_OO
{
    internal class ProfissionalSaude
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string RegistroConselho { get; set; }


        public ProfissionalSaude() { }  

        public ProfissionalSaude(string nome, string tipo, string registroConselho)
        {
            Nome = nome.ToUpper();
            Tipo = tipo.ToUpper();
            RegistroConselho = registroConselho.ToUpper();
        }

        public string SobreNome()
        {
            string[] lista = Nome.Split();//Anthony Gabriel Rocha
            //lista [Anthony, Gabriel, Rocha]

            return lista[lista.Length - 1] + " - " + RegistroConselho;
        }
    }
}
