using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Desafio
{
    
    internal class Comunicacao
    {

        public static bool validaNome(string nome){
            string []vetor = nome.Split();
            if (vetor.Length < 2){
                return false;
            }
            return true;
        }

        public static bool validaData(string data)
        {
            //   dd/mm/aaaa --- exemplo de 'preocupacao'
            string []vetor = data.Split('/');

            if (vetor.Length != 3 || vetor[0].Length > 2 || vetor[1].Length > 2 || vetor[2].Length != 4) {
                return false;
            }
            return true;
        }

        public static void listar(List<Pessoa> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public static void excluir(List<Pessoa> lista, string nomeArquivo)
        {
            string nome;
            Console.Write("Digite nome a ser excluido: ");
            nome = Console.ReadLine().ToUpper();

            bool removeu = false;
            foreach (var item in lista)
            {
                if (nome == item.Nome) {
                    lista.Remove(item);
                    removeu = true;
                    System.Console.WriteLine("Pessoa excluida da base de dados!");
                    break;
                }
            }
            if (removeu) {
                Persistencia.gravarListaArquivo(lista, "dados.dat");
            }
        }

        public static void cadastrar(List<Pessoa> lista, string nomeArquivo) 
        {
            string nome;
            string dataNascimento;
            Pessoa pessoa;
            
            do 
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine().ToUpper();
            } while (!validaNome(nome));

            do
            {
                Console.Write("Data Nascimento: ");
                dataNascimento = Console.ReadLine();
            } while (!validaData(dataNascimento));

            pessoa = new Pessoa(nome, dataNascimento);

            if (!lista.Contains(pessoa)) 
            {
                lista.Add( pessoa );
                Persistencia.atualizarPessoaArquivo(pessoa, "dados.dat");
                Console.WriteLine("Pessoa cadastrada na base de dados");
            } else
            {
                Console.WriteLine("Pessoa com este email já na base de dados");
            }
        }
    }        
}