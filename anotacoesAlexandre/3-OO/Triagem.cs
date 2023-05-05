using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_OO
{
    internal class Triagem
    {
        public ProfissionalSaude Responsavel { get; set; }
        public Paciente Paciente { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double PressaoArterial { get; set; }
        public double Temperatura { get; set; }

        public string Urgencia { get; set; }

        public Triagem(ProfissionalSaude responsavel, Paciente paciente, double peso, double altura, double pressaoArterial, double temperatura, string urgencia)
        {
            Responsavel = responsavel;
            Paciente = paciente;
            Peso = peso;
            Altura = altura;
            PressaoArterial = pressaoArterial;
            Temperatura = temperatura;
            Urgencia = urgencia;
        }
    }
}
