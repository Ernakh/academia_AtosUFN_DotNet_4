namespace Aula0805
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* int idade;
            string nome;
           
  
           Console.WriteLine("Digite o nome e idade: ");
            nome = Console.ReadLine();
            idade = int.Parse(Console.ReadLine());*/
            //p = new Pessoa(nome, idade);


            /* para termos acesso a atributos privados, para atribuição e para acesso
             * acesso - queira usar esses atributos, ou apresentar
             A forma ter acesso é utilizando os getters (para acesso) e os setters (para atribuição)
            get - metodo para obter os dados como retorno
             */
            //Console.WriteLine("Nome: "+p.nome +" Salário: "+p.salario); não funciona pois é private
            /*

                        Pessoa p;
                        p = new Pessoa();
                        Console.WriteLine("Digite o nome : ");
                        string nome = Console.ReadLine();
                        p.Nome = nome;

                        string nomeRetornado;
                        nomeRetornado = p.Nome;

                        Console.WriteLine("Nome: "+nomeRetornado);*/

            Carro c = new Carro();
            c.Marca = "VW";
            c.Ano = 1999;
            c.Modelo = "Gol";
            c.Motor = new Motor();
            c.Motor.Cilindradas = 1500;
            //c.Motor.Ligado = 1000;

            while (true)
            {
                Console.WriteLine("Digite 1 para ligar e 2 para desligar: ");
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    c.LigarCarro();
                }
                else if(op == 2)
                {
                    c.DesligarCarro();
                }
                else if (op == 0)
                {
                    break;
                }

            }
            

         }
    }
}