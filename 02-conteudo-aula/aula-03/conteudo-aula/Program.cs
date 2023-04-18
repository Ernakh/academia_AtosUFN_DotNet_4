// Estruturas condicionais
// - Permite que uma condição seja testada
// - De acordo o resultado da condição, o código tera seu fluxo desviado, executando um bloco de código ou outro
// - A condição é testada através de uma expressão booleana
// - A expressão booleana é uma expressão que retorna um valor booleano (true ou false)
// - A expressão booleana é testada através de operadores relacionais e lógicos
// - Operadores relacionais: ==, !=, >, <, >=, <=
// - Operadores lógicos: &&, ||, !
// - O primeiro caso de teste é obrigatório, e somente sera executado se a condição for verdadeira.


// Condição simples: if

bool condicao = true;

if (condicao)
{
    Console.WriteLine("A condição é verdadeira, e o bloco de código será executado");
}

Console.WriteLine($"\n===============================\n");

Console.WriteLine($"Digite um número inteiro: ");
int num = int.Parse(Console.ReadLine()!);

if (num > 0)
{
    Console.WriteLine($"O número {num} é positivo");
}

Console.WriteLine($"\n===============================\n");

// Condição composta: if-else

if (condicao)
{
    Console.WriteLine("A condição é verdadeira, e apenas o bloco da condição verdadeira será executado");
}
else
{
    Console.WriteLine("A condição é falsa, e apenas o bloco da condição falsa será executado");
}

Console.WriteLine($"\n===============================\n");

Console.WriteLine($"Digite um número inteiro: ");
num = int.Parse(Console.ReadLine()!);

if (num > 0)
{
    Console.WriteLine($"O número {num} é positivo");
}
else
{
    Console.WriteLine($"O número {num} é negativo");
}

// Condição encadeada: if-else-if
// - A condição encadeada é uma condição composta que possui mais de uma condição
// - A condição encadeada é executada de cima para baixo, e a primeira condição verdadeira é executada
// - A condição encadeada é executada podendo ou não entrar em alguma condição
// - Apenas uma condição será executada


Console.WriteLine($"\n===============================\n");

Console.WriteLine($"Digite um número inteiro: ");
num = int.Parse(Console.ReadLine()!);

if (num > 0)
{
    Console.WriteLine($"O número {num} é positivo");
}
else if (num < 0)
{
    Console.WriteLine($"O número {num} é negativo");
}
else
{
    Console.WriteLine($"O número {num} é ZERO");
}

Console.WriteLine($"\n===============================\n");

// Sobre módulo:
// - O módulo de um número é o resto da divisão desse número por outro
// - O módulo é representado pelo operador %
// - O resto da divisão de um número por outro é o número que sobra da divisão
// - Para descobrir se o um número é par ou impar, basta verificar se o resto da divisão desse número por 2 é igual a 0

Console.WriteLine($"Digite um número inteiro: ");
num = int.Parse(Console.ReadLine()!);

if (num % 2 == 0)
{
    Console.WriteLine($"O número {num} é par");
}
else
{
    Console.WriteLine($"O número {num} é impar");
}

Console.WriteLine($"\n===============================\n");

// Obs: O operador % é um operador de resto de divisão, portanto podemos utilizar ele para verificar se um número é divisível por outro

Console.WriteLine($"Digite um número inteiro: ");
num = int.Parse(Console.ReadLine()!);

if (num % 4 == 0)
{
    Console.WriteLine($"O número {num} é divisível por 2");
}
else if (num % 8 == 0)
{
    Console.WriteLine($"O número {num} é divisível por 4");
}
else if (num % 16 == 0)
{
    Console.WriteLine($"O número {num} é divisível por 8");
}
else
{
    Console.WriteLine($"O número {num} não é divisível por 4, 8 ou 16");
}

Console.WriteLine($"\n===============================\n");

// Melhorando a legibilidade do código.

// - As chave são opcionais quando o bloco de código possui apenas uma linha
// - As chaves são obrigatórias quando o bloco de código possui mais de uma linha

// Condicao simples: if
if (condicao)
    Console.WriteLine("A condição é verdadeira, e o bloco de código será executado");

Console.WriteLine($"\n===============================\n");

Console.WriteLine($"Digite um número inteiro: ");
int num = int.Parse(Console.ReadLine()!);

if (num > 0)
    Console.WriteLine($"O número {num} é positivo");

Console.WriteLine($"\n===============================\n");

// Condição composta: if-else
if (condicao)
    Console.WriteLine("A condição é verdadeira, e apenas o bloco da condição verdadeira será executado");
else
    Console.WriteLine("A condição é falsa, e apenas o bloco da condição falsa será executado");


Console.WriteLine($"\n===============================\n");

// Condição encadeada: if-else-if
Console.WriteLine($"Digite um número inteiro: ");
num = int.Parse(Console.ReadLine()!);

if (num > 0)
    Console.WriteLine($"O número {num} é positivo");
else if (num < 0)
    Console.WriteLine($"O número {num} é negativo");
else
    Console.WriteLine($"O número {num} é ZERO");

Console.WriteLine($"\n===============================\n");

// Sobre módulo:
Console.WriteLine($"Digite um número inteiro: ");
num = int.Parse(Console.ReadLine()!);

if (num % 2 == 0)
    Console.WriteLine($"O número {num} é par");
else
    Console.WriteLine($"O número {num} é impar");

Console.WriteLine($"\n===============================\n");

// Verificando divisibilidade
Console.WriteLine($"Digite um número inteiro: ");
num = int.Parse(Console.ReadLine()!);

if (num % 4 == 0)
    Console.WriteLine($"O número {num} é divisível por 2");
else if (num % 8 == 0)
    Console.WriteLine($"O número {num} é divisível por 4");
else if (num % 16 == 0)
    Console.WriteLine($"O número {num} é divisível por 8");
else
    Console.WriteLine($"O número {num} não é divisível por 4, 8 ou 16");

Console.WriteLine($"\n===============================\n");

// Melhorando ainda mais a legibilidade do código

// Operador ternário
// - O operador ternário é uma forma reduzida de escrever uma condição composta
// - O operador ternário é composto por uma condição, um valor verdadeiro e um valor falso
// - A operador ternário deve ser atribuído a uma variável
// - É recomendado utilizar o operador ternário apenas quando a condição for simples

// Condição composta: if-else
string verdadeiraOuFalsa = condicao ? "A condição é Verdadeira" : "A condição é falsa";
Console.WriteLine($"{verdadeiraOuFalsa}");

Console.WriteLine($"\n===============================\n");

// Condição encadeada: if-else-if
Console.WriteLine($"Digite um número inteiro: ");
num = int.Parse(Console.ReadLine()!);

string resultado = num > 0 ? $"O número {num} é positivo"
                    : num < 0 ? $"O número {num} é negativo"
                    : $"O número {num} é ZERO";

Console.WriteLine($"{resultado}");

Console.WriteLine($"\n===============================\n");

// Sobre módulo:
Console.WriteLine($"Digite um número inteiro: ");
num = int.Parse(Console.ReadLine()!);

resultado = num % 2 == 0 ? $"O número {num} é par" : $"O número {num} é impar";

Console.WriteLine($"{resultado}");

Console.WriteLine($"\n===============================\n");

// Verificando divisibilidade
Console.WriteLine($"Digite um número inteiro: ");
num = int.Parse(Console.ReadLine()!);

resultado = num % 4 == 0 ? $"O número {num} é divisível por 2"
                : num % 8 == 0 ? $"O número {num} é divisível por 4"
                : num % 16 == 0 ? $"O número {num} é divisível por 8"
                : $"O número {num} não é divisível por 4, 8 ou 16";

Console.WriteLine($"{resultado}");
