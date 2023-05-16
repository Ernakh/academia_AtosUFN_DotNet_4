using _4_Arquivo;
Console.Clear();
List<Pessoa> listaPessoas = new List<Pessoa>();

Persistencia.popularArquivoLista("dados.dat", listaPessoas);

string nome;
string dataNascimento;
Pessoa pessoa;
// for (int i = 0; i < 3; i++)
// {
//     Console.Write("Nome: ");
//     nome = Console.ReadLine();

//     Console.Write("Data Nascimento: ");
//     dataNascimento = Console.ReadLine();

//     pessoa = new Pessoa(nome, dataNascimento);

//     if (!listaPessoas.Contains(pessoa)) //????
//     {
//         listaPessoas.Add( pessoa );
//         Persistencia.atualizarPessoaArquivo(pessoa, "dados.dat");
//     } else
//     {
//         Console.WriteLine("Pessoa com este email já na base de dados");
//     }
// }

Persistencia.exibirLista(listaPessoas);

Console.Write("Digite nome a ser excluido: ");
nome = Console.ReadLine();

bool removeu = false;
foreach (var item in listaPessoas)
{
    if (nome == item.Nome) {
        listaPessoas.Remove(item);
        removeu = true;
        break;
    }
}
if (removeu) {
    Persistencia.gravarListaArquivo(listaPessoas, "dados.dat");
}



//Persistir na base de dados
//Persistencia.gravarListaArquivo(listaPessoas, "C:\\Users\\alexz\\academia_AtosUFN_DotNet_4\\anotacoesAlexandre\\dados.dat");