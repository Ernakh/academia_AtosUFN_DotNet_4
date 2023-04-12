//Statement é um termo em programação que se refere a uma instrução ou comando em um código fonte.  é uma unidade básica de execução em um programa.

// Exemplo: uma declaração de variável, uma atribuição de valor a uma variável, uma instrução condicional (como um if ou switch), um loop (como um for ou while), uma chamada de função, entre outras.

// Exemplos de instruções em C#:

// Calculos:
int a = 10;
int b = 20;
int c = a + b;

// Mostrar uma informação na tela:
Console.WriteLine("Hello World!");

// Ler uma informação do teclado:
Console.ReadLine();

// Testar condições:
if (a > b)
{
    Console.WriteLine("A é maior que B");
}
else
{
    Console.WriteLine("B é maior que A");
}

// Dados:

// Pode ser caracterizado como uma fração das INFORMAÇÕES a serem processadas pelo computador.

// Algoritmo soma_numeros

// Declaração de variáveis
int n1, n2, resultado;

//Inicio
n1 = 5;
n2 = int.Parse(Console.ReadLine()!);

resultado = n1 + n2;

Console.WriteLine(resultado);
//Fim

// Classificação dos dados:

// - Numéricos: int, float, double, decimal, long, short, byte, sbyte, uint, ulong, ushort

// - Caracteres: char

// - Texto: string

// - Lógicos/Booleanos: bool

// Exemplo de dados numéricos:

// Numeros inteiros:
int inteiro1 = 0, inteiro2 = 35, inteiro3 = -53;
long longo1 = 0L, longo2 = 35L, longo3 = -53L;

//Numeros reais:
float flutuante1 = 0.0f, flutuante2 = 3.5f, flutuante3 = -5.3f;
double duplo1 = 0.0, duplo2 = 3.5, duplo3 = -5.3;
decimal decimal1 = 0.0m, decimal2 = 3.5m, decimal3 = -5.3m;

// Exemplo de dados de caracteres:
char letra1 = 'a', letra2 = 'b', letra3 = 'c';

// Exemplo de dados de texto:
string texto1 = "Olá", texto2 = "Mundo", texto3 = "!!!";

// Exemplo de dados lógicos/booleanos:
bool verdadeiro = true, falso = false;

// Importante: A diferença se dá na forma como são declarados e armazenados na memória.

// Nota: Um dado do tipo texto, tambem conhecido como string é uma sequência de caracteres.

// Regras para nomear variáveis:

// - Possuir um ou mais caracteres;
// - Não pode começar com números;
// - Não pode conter espaços;
// - Não pode conter caracteres especiais, exceto o underline (_);


// Exemplo de nome de variáveis:

int numero1 = 10;
float numero2 = 10.5f;
string nome = "João";
bool booleano = true;
double _real = 10.5;
long nu_me_ro = 10L;

// Valores maximos e minimos de cada tipo de dado:

int valorMaximoInt = int.MaxValue;
int valorMinimoInt = int.MinValue;
Console.WriteLine($"Valor máximo de int: {valorMaximoInt}");
Console.WriteLine($"Valor mínimo de int: {valorMinimoInt}");

long valorMaximoLong = long.MaxValue;
long valorMinimoLong = long.MinValue;
Console.WriteLine($"Valor máximo de long: {valorMaximoLong}");
Console.WriteLine($"Valor mínimo de long: {valorMinimoLong}");

float valorMaximoFloat = float.MaxValue;
float valorMinimoFloat = float.MinValue;
Console.WriteLine($"Valor máximo de float: {valorMaximoFloat}");
Console.WriteLine($"Valor mínimo de float: {valorMinimoFloat}");

double valorMaximoDouble = double.MaxValue;
double valorMinimoDouble = double.MinValue;
Console.WriteLine($"Valor máximo de double: {valorMaximoDouble}");
Console.WriteLine($"Valor mínimo de double: {valorMinimoDouble}");

decimal valorMaximoDecimal = decimal.MaxValue;
decimal valorMinimoDecimal = decimal.MinValue;
Console.WriteLine($"Valor máximo de decimal: {valorMaximoDecimal}");
Console.WriteLine($"Valor mínimo de decimal: {valorMinimoDecimal}");
// Nota: O tipo de dado decimal é o mais preciso, porém é o mais lento.

char valorMaximoChar = char.MaxValue;
char valorMinimoChar = char.MinValue;
Console.WriteLine($"Valor máximo de char: {valorMaximoChar}");
Console.WriteLine($"Valor mínimo de char: {valorMinimoChar}");
// Nota: O tipo de dado char é um tipo de dado numérico que representa um caractere Unicode.

// No caso de uma variável do tipo string, não existe um valor máximo definido como nos tipos de dados numéricos. A capacidade de armazenamento de uma variável string é limitada apenas pela memória disponível do computador ou pelo ambiente de execução.	

// Nota: O tipo de dado string é um tipo de dado que representa uma sequência de caracteres Unicode.


// OPERADORES NA LINGUAGEM C#

// Operadores são símbolos que representam uma operação matemática, lógica ou relacional.

// Operadores aritméticos:

// - Inversão de sinal: -
// - Soma: +
// - Subtração: -
// - Multiplicação: *
// - Divisão: /
// - Módulo: %
// - Incremento: ++ , +=
// - Decremento: --, -=
