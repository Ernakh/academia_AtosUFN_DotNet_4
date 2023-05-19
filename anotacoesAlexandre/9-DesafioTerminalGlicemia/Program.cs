using _9_DesafioTerminalGlicemia;

// solicitar pro usuario o nome e o caminho do arquivo
string nomeArquivo;

Console.Clear();
Console.Write("Digite caminho e nome do arquivo com dados glicêmicos: ");
nomeArquivo = Console.ReadLine();

//necessidade de uma lista de dados glicemicos
List<Glicemia> listaGlicemica = new List<Glicemia>();

// capturar linha a linha do arquivo, jogar para um objeto e adicionar na lista
Persistencia.popularArquivoLista(nomeArquivo, listaGlicemica);


// calcular a media
Console.WriteLine("A média glicêmica: " + Estatistica.calcularMedia(listaGlicemica));

//calcular a mediana - antes é preciso ordenar a lista pelo campo valor da glicemia
Console.WriteLine("A mediana: " + Estatistica.calcularMediana(listaGlicemica));

// exibir os dados da lista
//Comunicacao.exibir(listaGlicemica);
