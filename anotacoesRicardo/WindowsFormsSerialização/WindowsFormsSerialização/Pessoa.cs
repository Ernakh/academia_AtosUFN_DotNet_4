using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsSerialização
{
    [Serializable]
    public class Pessoa
    {
        public string nome;
        public int idade;
        [NonSerialized]
        [XmlIgnore]//adicionar depois de finalizar o SOAP
        public float salario;
    }
}
