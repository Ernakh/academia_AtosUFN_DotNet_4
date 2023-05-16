using _6_ListaOrdenada;

List<int> listaInteiros = new List<int>();

listaInteiros.Add(6);
listaInteiros.Add(1);
listaInteiros.Add(4);
listaInteiros.Add(7);
listaInteiros.Add(2);

listaInteiros.Sort();

foreach (var item in listaInteiros)
{
    System.Console.WriteLine(item);
}

List<Pessoa> listaPessoas = new List<Pessoa>();
listaPessoas.Add( new Pessoa(45,"Jonathan") );
listaPessoas.Add( new Pessoa(5,"Pedro") );
listaPessoas.Add( new Pessoa(4,"Zeno") );
listaPessoas.Add( new Pessoa(75,"Alexandre") );

listaPessoas.Sort();

foreach (var item in listaPessoas)
{
    System.Console.WriteLine(item.nome + " - " + item.codigo);
}


