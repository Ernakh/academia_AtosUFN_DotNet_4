// Listas 

/**
É muito comum em programação a necessidade de armazenar uma coleção de dados, como uma lista de compras, uma lista de tarefas, uma lista de contatos, etc. Para isso, podemos utilizar uma estrutura de dados chamada lista.

Uma lista é uma estrutura de dados que armazena uma coleção de elementos. Esses elementos podem ser de qualquer tipo, inclusive outros objetos. A lista é uma estrutura de dados dinâmica, ou seja, ela pode aumentar ou diminuir de tamanho conforme a necessidade.

Em C#, podemos utilizar a classe List<T> para criar uma lista. O T entre os sinais de menor e maior indica que a lista pode armazenar elementos de qualquer tipo. Por exemplo, podemos criar uma lista de inteiros, uma lista de strings, uma lista de objetos da classe Pessoas, etc.

Para utilizar a classe List<T>, precisamos importar o namespace System.Collections.Generic. Veja um exemplo de como criar uma lista de inteiros:

Ao trabalhar com listas, é muito comum a necessidade de manipular os elementos da lista. Por exemplo, podemos precisar adicionar um elemento no final da lista, remover um elemento da lista, ordenar os elementos da lista, etc. Para isso, a classe List<T> possui diversos métodos que nos ajudam a manipular os elementos da lista.

Vejamos alguns métodos da classe List<T>:
*/

List<String> frutas = new List<String>(){
    "Banana",
    "Maçã",
    "Laranja"
};

// .ForEach() - Executa uma ação para cada elemento da lista.
frutas.ForEach(fruta => Console.WriteLine(fruta));
// => Banana Maçã Laranja

// .Add() - Adiciona um elemento no final da lista.
frutas.Add("Limão");
frutas.ForEach(fruta => Console.WriteLine(fruta));
// => Banana Maçã Laranja Limão

// .Insert() - Insere um elemento na posição especificada.
frutas.Insert(1, "Morango");
frutas.ForEach(fruta => Console.WriteLine(fruta));
// => Banana Morango Maçã Laranja Limão

// .Remove() - Remove a primeira ocorrência do elemento especificado.
frutas.Remove("Maçã");
frutas.ForEach(fruta => Console.WriteLine(fruta));
// => Banana Morango Laranja Limão

// .RemoveAt() - Remove o elemento no índice especificado.
frutas.RemoveAt(2);
frutas.ForEach(fruta => Console.WriteLine(fruta));
// => Banana Morango Limão

// .Contains() - Verifica se a lista contém o elemento especificado.
Console.WriteLine(frutas.Contains("Banana"));
// => True
Console.WriteLine(frutas.Contains("Laranja"));
// => False

// .IndexOf() - Retorna o índice da primeira ocorrência do elemento especificado.
Console.WriteLine(frutas.IndexOf("Banana"));
// => 0

// .LastIndexOf() - Retorna o índice da última ocorrência do elemento especificado.
frutas.Add("Banana");
Console.WriteLine(frutas.LastIndexOf("Banana"));
// => 3

// .Sort() - Ordena os elementos da lista.
frutas.Sort();
frutas.ForEach(fruta => Console.WriteLine(fruta));
// => Banana Banana Limão Morango

// .Reverse() - Inverte a ordem dos elementos da lista.
frutas.Reverse();
frutas.ForEach(fruta => Console.WriteLine(fruta));
// => Morango Limão Banana Banana

// .Count() - Retorna a quantidade de elementos da lista.
Console.WriteLine(frutas.Count());
// => 4

// .ToArray() - Converte a lista para um array.
String[] frutasArray = frutas.ToArray();
Console.WriteLine(frutasArray);
// => System.String[]

// .Clear() - Remove todos os elementos da lista.
frutas.Clear();
frutas.ForEach(fruta => Console.WriteLine(fruta));
// =>

// Dicionários
/**
Um dicionário é uma estrutura de dados que armazena uma coleção de elementos. Cada elemento do dicionário é composto por duas partes:
Uma chave e um valor. A chave é um identificador _ÚNICO_ que serve para identificar o elemento no dicionário. O valor é o dado que queremos armazenar no dicionário.

Implementa a interface IDictionary<TKey, TValue> e é uma coleção de pares de chave/valor. Uma chave não pode ser nula, mas um valor pode ser, se o tipo de valor for um tipo de referência.

Para utilizar a classe Dictionary<TKey, TValue>, precisamos importar o namespace System.Collections.Generic. Veja um exemplo de como criar um dicionário de inteiros:
*/

// Cria um dicionário de inteiros, onde a chave é um inteiro e o valor é uma string.

Dictionary<int, string> frutasTropicais = new Dictionary<int, string>() {
    { 1, "Banana" },
    { 2, "Maçã" },
    { 3, "Laranja" }
};
// Vejam alguns métodos da classe Dictionary<TKey, TValue>:

// Percorre todos os elementos do dicionário.

// Para fins didático criarei um método para imprimir os elementos do dicionário.

void ImprimirDicionario(Dictionary<int, string> dicionario) {
    foreach (KeyValuePair<int, string> fruta in dicionario) {
        Console.WriteLine("Chave: {0}, Valor: {1}", fruta.Key, fruta.Value);
    }
}

// .Add() - Adiciona um elemento no dicionário.
frutasTropicais.Add(4, "Limão");
ImprimirDicionario(frutasTropicais);
// => { 1, "Banana" }, { 2, "Maçã" }, { 3, "Laranja" }, { 4, "Limão" }

// .Remove() - Remove o elemento com a chave especificada.
frutasTropicais.Remove(2);
ImprimirDicionario(frutasTropicais);
// => { 1, "Banana" }, { 3, "Laranja" }, { 4, "Limão" }

// .Contains() - Verifica se o dicionário contém o elemento especificado.
Console.WriteLine(frutasTropicais.Contains(new KeyValuePair<int, string>(1, "Banana")));
// => True
Console.WriteLine(frutasTropicais.Contains(new KeyValuePair<int, string>(2, "Maçã")));
// => False

// .ContainsKey() - Verifica se o dicionário contém a chave especificada.
Console.WriteLine(frutasTropicais.ContainsKey(1));
// => True
Console.WriteLine(frutasTropicais.ContainsKey(2));
// => False

// .ContainsValue() - Verifica se o dicionário contém o valor especificado.
Console.WriteLine(frutasTropicais.ContainsValue("Banana"));
// => True
Console.WriteLine(frutasTropicais.ContainsValue("Maçã"));
// => False

// .TryGetValue() - Tenta obter o valor associado à chave especificada.
string valor;
if (frutasTropicais.TryGetValue(1, out valor)) {
    Console.WriteLine(valor);
}
// => Banana

// .Count() - Retorna a quantidade de elementos do dicionário.
Console.WriteLine(frutasTropicais.Count());
// => 3

// .IsReadOnly() - Retorna um valor que indica se o dicionário é somente leitura.
Console.WriteLine(frutasTropicais.IsReadOnly());
// => False

// .Item[] - Obtém ou define o valor associado à chave especificada.
Console.WriteLine(frutasTropicais[1]);
// => Banana
frutasTropicais[1] = "Banana da Terra";
Console.WriteLine(frutasTropicais[1]);
// => Banana da Terra

// .Keys - Obtém uma coleção de chaves que podem ser iteradas.
foreach (int chave in frutasTropicais.Keys) {
    Console.WriteLine(chave);
}
// => 1 3 4

// .Values - Obtém uma coleção de valores que podem ser iterados.
foreach (string valor in frutasTropicais.Values) {
    Console.WriteLine(valor);
}
// => Banana da Terra Laranja Limão

// .Sort() - Ordena os elementos do dicionário.
frutasTropicais.Sort();
ImprimirDicionario(frutasTropicais);
// => { 1, "Banana da Terra" }, { 3, "Laranja" }, { 4, "Limão" }

// .SortedDictionary() - Retorna um dicionário ordenado.
SortedDictionary<int, string> frutasTropicaisOrdenadas = new SortedDictionary<int, string>(frutasTropicais);
ImprimirDicionario(frutasTropicaisOrdenadas);
// => { 1, "Banana da Terra" }, { 3, "Laranja" }, { 4, "Limão" }

// .Clear() - Remove todos os elementos do dicionário.
frutasTropicais.Clear();
ImprimirDicionario(frutasTropicais);
// =>
