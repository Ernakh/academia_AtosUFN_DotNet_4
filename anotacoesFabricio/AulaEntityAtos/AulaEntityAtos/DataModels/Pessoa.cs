using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaEntityAtos.DataModels
{
    public class Pessoa
    {

        public int id { get; set; }
        public string nome { get; set; }

        public virtual ICollection<Email> emails { get; set; }
        
    }
}
