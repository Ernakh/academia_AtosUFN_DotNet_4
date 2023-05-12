using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Arquivo
{
    internal class Persistencia
    {
        /// <summary>
        /// método de classe que sabe ler o conteúdo de um arquivo, linha a linha e jogar na tela
        /// </summary>
        /// <param name="nomeArquivo"></param>
        public static void lerArquivoParaTela(string nomeArquivo)
        {
            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
            do
            {
                Console.WriteLine(leitor.ReadLine());
            } while (!leitor.EndOfStream);
            leitor.Close();
        }


        public static void lerArquivoExibeNomes(string nomeArquivo)
        {
            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
            string[] vetorLinha; //[nome, email, dataNascimento]
            string linha;
            do
            {
                linha = leitor.ReadLine();
                vetorLinha = linha.Split(";");
                Console.WriteLine(vetorLinha[0]);
            } while (!leitor.EndOfStream);
            leitor.Close();
        }
    }
}
