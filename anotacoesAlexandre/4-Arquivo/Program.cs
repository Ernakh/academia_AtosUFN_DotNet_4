using _4_Arquivo;

List<Pessoa> listaPessoas = new List<Pessoa>();

Persistencia.popularArquivoLista("C:\\Users\\alexz\\academia_AtosUFN_DotNet_4\\anotacoesAlexandre\\dados.dat", listaPessoas);

Persistencia.exibirLista(listaPessoas);