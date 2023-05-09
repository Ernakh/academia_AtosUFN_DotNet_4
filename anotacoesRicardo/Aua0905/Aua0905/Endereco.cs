using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aua0905
{
    internal class Endereco
    {
        private string _rua;
        private int _num;
        private string _complemento;

        public string Rua
        { 
            get { return _rua; }
            set { _rua = value; }
        }
        public int Num
        {
            get { return _num; } 
            set { _num = value;  }
        }
        public string Complemento
        {
            get { return _complemento;  }
            set { _complemento = value;  }
        }

    }
}
