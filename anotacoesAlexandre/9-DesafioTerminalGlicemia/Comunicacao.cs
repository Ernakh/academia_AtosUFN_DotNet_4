using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_DesafioTerminalGlicemia
{
    
    internal class Comunicacao
    {
        public static void exibir(List<Glicemia> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }        
}