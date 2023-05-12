using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Arquivo
{
    /// <summary>
    /// classe responsavel em ler e escrever pessoas ou listas em arquivos csv
    /// </summary>
    internal class Persistencia
    {
        /// <summary>
        /// método de classe que sabe ler o conteúdo de um arquivo, linha a linha e jogar na tela
        /// </summary>
        /// <param name="nomeArquivo"></param>
        public static void lerArquivoParaTela(string nomeArquivo)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                do
                {
                    Console.WriteLine(leitor.ReadLine());
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }         
        }

        /// <summary>
        /// metodo de classe que le um arquivo csv e exibe somente os nomes cadastrados
        /// </summary>
        /// <param name="nomeArquivo"></param>
        public static void lerArquivoExibeNomes(string nomeArquivo)
        {
            try
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
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }
        }

        public static void popularArquivoLista(string nomeArquivo, List<Pessoa> lista)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string[] vetorLinha; //[nome, email, dataNascimento]
                string linha;
                do
                {
                    linha = leitor.ReadLine();//Leandro Di Nardo Lazarin;lazarin@ufn.edu.br;12/12/1990
                    vetorLinha = linha.Split(";"); //[Leandro Di Nardo Lazarin, lazarin@ufn.edu.br, 12/12/1990]
                    lista.Add(new Pessoa(vetorLinha[0], vetorLinha[1], vetorLinha[2]));
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }            
        }

        public static void exibirLista(List<Pessoa> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public static void gravarListaArquivo(List<Pessoa> lista, string nomeArquivo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo); //sempre o arquivo é criado do zero
                                                                       //StreamWriter escritor = new StreamWriter(nomeArquivo, append:true); //possibilidade de adionar dados no arquivo
                foreach (var item in lista)
                {
                    escritor.WriteLine(item.Nome + ";" + item.Email + ";" + item.DataNascimento);
                    escritor.Flush();
                }
                escritor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }            
        }

        /// <summary>
        /// método de classe que grava uma pessoa no arquivo, representado pelo nomeArquivo
        /// </summary>
        /// <param name="pessoa"></param>
        /// <param name="nomeArquivo"></param>
        public static void atualizarPessoaArquivo(Pessoa pessoa, string nomeArquivo) 
        {
            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo, append: true);

                escritor.WriteLine(pessoa.Nome + ";" + pessoa.Email + ";" + pessoa.DataNascimento);

                escritor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo");
            }            
        }
    }
}
