using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aua0905
{
    internal class Pessoa
    {
        private string _nome;
        private string _email;
        private Endereco _end;
         
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public Endereco End 
        {
            get { return _end;  }
            set { _end = value;  }
        }
    }
}
