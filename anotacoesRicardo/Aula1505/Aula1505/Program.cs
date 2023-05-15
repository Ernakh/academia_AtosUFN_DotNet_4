namespace Aula1505
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello, World!");

            Veiculo v = new Veiculo();
            v._potencia = 500;
            v._modelo = "Gol";
            v.Ligar();


            VeiculoEletrico ve = new VeiculoEletrico();
            ve._potencia = 100;
            ve._modelo = "Tesla";
            ve._autonomia = 10;
            ve.Ligar();
            ve.Carregar();

            Motocicleta m = new Motocicleta();
            m.Ligar();

            Veiculo vei;
            Console.WriteLine("Digite V para criar um Veiculo base\nDigite E para criar um Veiculo eletrico");
            Console.WriteLine("Digite M para criar uma Motocicleta");
            char op;
            op = char.Parse(Console.ReadLine());

            if(op == 'V')
                vei = new Veiculo();
            else if (op=='E')
                vei = new VeiculoEletrico();
            else if (op  == 'M')
                vei = new Motocicleta();
            else
                vei = new Veiculo();

            vei.Ligar(); */


            //Animal a = new Animal("Ricardo", 35);

            Cavalo c = new Cavalo("Ricardo", 35, "Vira lata");
            c.emitirSom();

            Cachorro cc = new Cachorro("Caramelo", 10);
            cc.p = new Pessoa("Ricardo");
            cc.p.end = new Endereco("Andradas", "97060-000", 1614);

            Console.WriteLine("O cachorro: "+cc.Nome+" é do "+cc.p.Nome);
            Console.WriteLine("E mora na rua "+cc.p.end.Rua+" numero "+cc.p.end.Numero);

            Pessoa pessoa = new Pessoa("Ayong");
            pessoa.caes = new List<Cachorro>();
            pessoa.caes.Add(cc);
            pessoa.caes.Add(new("Guaipeca", 5));
            pessoa.caes.Add(new("Snow", 6));
            pessoa.caes.Add(new("Hugo", 15));

            for(int i=0; i<pessoa.caes.Count; i++)
            {
                Console.WriteLine("Cão "+i+ ": " + pessoa.caes[i].Nome);
            }

            foreach(Cachorro cao in pessoa.caes)
            {
                Console.WriteLine("Cão no foreach: " + cao.Nome);
            }
        }
    }
}