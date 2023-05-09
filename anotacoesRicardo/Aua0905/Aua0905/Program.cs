using System.Runtime.InteropServices;

namespace Aua0905
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ContaBancaria c = new ContaBancaria();
             Console.WriteLine("Bem vindo ao caixa eletronico: ");

             Console.WriteLine("Digite o numero da conta: ");
             c.NumeroConta = Console.ReadLine();
             Console.WriteLine("Digite o nome do titular: ");
             c.Titular = Console.ReadLine();
             Console.WriteLine("Digite o limite da conta: ");
             c.Limite = double.Parse(Console.ReadLine());
             Console.Clear();

             while (true)
             {
                 int op;
                 double valor;
                 Console.WriteLine("Digite: \n1 - Sacar\n2 - Depositar\n3 - Mostrar saldo\n0 - Sair");
                 op = int.Parse(Console.ReadLine());
                 if (op == 1)
                 {
                     Console.WriteLine("Digite o valor do saque: ");
                     valor = double.Parse(Console.ReadLine());
                     if (c.Sacar(valor))
                         Console.WriteLine("Saque efetuado. Saldo atual: " + c.Saldo);
                     else
                         Console.WriteLine("Saque não efetuado, sem saldo.");

                 }
                 else if(op == 2)
                 {
                     Console.WriteLine("Digite o valor do depósito: ");
                     valor = double.Parse(Console.ReadLine());
                     c.Depositar(valor);

                 }
                 else if (op == 3)
                 {
                     Console.Clear();
                     Console.WriteLine("Os dados da conta: ");
                     Console.WriteLine("Número: " + c.NumeroConta);
                     Console.WriteLine("Titular: " + c.Titular);
                     Console.WriteLine("Limite: " + c.Limite);
                     Console.WriteLine("Saldo: " + c.Saldo);
                 }
                 else if (op == 0)
                 {
                     break;
                 }
                 else
                 {
                     Console.WriteLine("Operção inválida!");
                 }
             }*/

            Pessoa p1 = new Pessoa();
            p1.Nome = "Ricardo Frohlich";
            p1.Email = "ricardo@frohlich.br";
            /*Console.WriteLine("Nome: "+p1.Nome);
            Console.WriteLine("E-mail: "+p1.Email);*/
            p1.End = new Endereco();
            p1.End.Rua = "Rua dos Andradas";
            p1.End.Num = 1614;
            p1.End.Complemento = "Conjunto I - UFN";
            /*Console.WriteLine("Endereço:\nRua: "+p1.End.Rua);
            Console.WriteLine("Número: "+p1.End.Num);
            Console.WriteLine("Complemento: "+p1.End.Complemento);*/
            Pessoa p2 = new Pessoa();
            p2.Nome = "Fabricio";
            p2.Email = "fabricio@ufn.edu.br";
            p2.End = new Endereco();
            p2.End.Rua = "Rua dos Andradas";
            p2.End.Num = 1614;
            p2.End.Complemento = "Conjunto I - UFN";
            Pessoa p3 = new Pessoa();
            p3.Nome = "Alexandre";
            p3.Email = "alexandre@ufn.edu.br";
            p3.End = new Endereco();
            p3.End.Rua = "Rua dos Andradas";
            p3.End.Num = 1614;
            p3.End.Complemento = "Conjunto I - UFN";


            List<Pessoa> listaPessoas = new List<Pessoa>();
            listaPessoas.Add(p1);
            listaPessoas.Add(p2);
            listaPessoas.Add(p3);

            foreach(Pessoa pessoa in listaPessoas)
            {
                Console.WriteLine("Nome: "+pessoa.Nome);
                Console.WriteLine("E-mail: " +pessoa.Email);
                Console.WriteLine("Rua: " + pessoa.End.Rua);
                Console.WriteLine("Número: "+pessoa.End.Num);
                Console.WriteLine("Complemento: "+pessoa.End.Complemento);
            }  
            
            for(int i = 0;i<listaPessoas.Count;i++)
            {
                Console.WriteLine("Elemento "+i+" Nome: " + listaPessoas[i].Nome);
            }

        }
    }
}