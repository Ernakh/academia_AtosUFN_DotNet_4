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

        public static void listar(List<Pessoa> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
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

            Console.Write("Data Nascimento: ");
            dataNascimento = Console.ReadLine();

            pessoa = new Pessoa(nome, dataNascimento);

            if (!lista.Contains(pessoa)) 
            {
                lista.Add( pessoa );
                Persistencia.atualizarPessoaArquivo(pessoa, "dados.dat");
            } else
            {
                Console.WriteLine("Pessoa com este email já na base de dados");
            }
        }
    }        
}