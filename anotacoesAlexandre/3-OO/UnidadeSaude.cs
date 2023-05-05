using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_OO
{
    internal class UnidadeSaude
    {        
        
        public string Nome { set; get; }
        public string Sigla { get; set; }

        public ProfissionalSaude Responsavel { set; get; }  

        public UnidadeSaude(string nome, string sigla)
        {
            Nome = nome.ToUpper();
            Sigla = sigla.ToUpper();
            Responsavel = new ProfissionalSaude(); //instanciando um responsavel, mas sem defini-lo
        }
    }
}
