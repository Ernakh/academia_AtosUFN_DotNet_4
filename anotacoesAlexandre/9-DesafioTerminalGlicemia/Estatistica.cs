using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_DesafioTerminalGlicemia
{
    internal class Estatistica 
    {
        public static double calcularMedia(List<Glicemia> lista)
        {
            // try
            // {
            //     double media = 0;
            //     foreach (var item in lista)
            //     {
            //         media += item.valor;
            //     }

            //     return media / lista.Count;
            // }
            // catch (System.Exception)
            // {
            //     return 0;
            // }           

            if (lista.Count == 0) {
                return 0;
            }
            return lista.Sum(x => x.valor) / lista.Count;
        }

        public static double calcularMediana(List<Glicemia> lista)
        {
            
            List<Glicemia> listaTemp = new List<Glicemia>();
            listaTemp.AddRange(lista); //copia o conteudo de lista para dentro de listaTemp
            
            
            
            listaTemp.Sort(); //objetos com data e valor

            int i;
            for (i = 0; i < (int)lista.Count / 2; i++);

            return (double)lista[i].valor;



        }
    }
}