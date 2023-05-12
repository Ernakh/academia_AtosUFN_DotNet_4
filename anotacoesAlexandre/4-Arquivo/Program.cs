using _4_Arquivo;

List<Pessoa> listaPessoas = new List<Pessoa>();

Persistencia.popularArquivoLista("C:\\Users\\alexz\\academia_AtosUFN_DotNet_4\\anotacoesAlexandre\\dados.dat", listaPessoas);

//Persistencia.exibirLista(listaPessoas);


string nome;
string dataNascimento;
Pessoa pessoa;
for (int i = 0; i < 3; i++)
{
    Console.Write("Nome: ");
    nome = Console.ReadLine();

    Console.Write("Data Nascimento: ");
    dataNascimento = Console.ReadLine();

    pessoa = new Pessoa(nome, dataNascimento);

    if (!listaPessoas.Contains(pessoa)) //????
    {
        listaPessoas.Add( pessoa );
        Persistencia.atualizarPessoaArquivo(pessoa, "C:\\Users\\alexz\\academia_AtosUFN_DotNet_4\\anotacoesAlexandre\\dados.dat");
    } else
    {
        Console.WriteLine("Pessoa com este email já na base de dados");
    }
}

//Persistir na base de dados
//Persistencia.gravarListaArquivo(listaPessoas, "C:\\Users\\alexz\\academia_AtosUFN_DotNet_4\\anotacoesAlexandre\\dados.dat");