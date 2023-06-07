using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaEntityAtos.DataModels
{
    public class Email
    {
        public int id { get; set; }

        [Required]
        public string email { get; set; }
        public virtual Pessoa pessoa { get; set; }
    }
}
