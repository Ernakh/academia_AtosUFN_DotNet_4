// Encadeamento de condicionais
// - Permite que uma condição seja testada e o fluxo do código seja desviado dentro de outra condição

bool condicao = true;
bool condicao2 = true;

if (condicao)
{
    Console.WriteLine("A condição é verdadeira, e o primeiro bloco de código será executado");

    if (condicao2)
    {
        Console.WriteLine("A condição é verdadeira, e o bloco de código será executado");
    }
    else
    {
        Console.WriteLine("A condição é falsa, e o bloco de código não será executado");
    }

    Console.WriteLine("A condição é verdadeira, e ainda estamos no primeiro bloco de código");
}
else
{
    Console.WriteLine("A condição é falsa, e somente nesse caso o bloco de código será executado");
}

Console.WriteLine($"\n===============================\n");

Console.WriteLine($"Digite um número inteiro: ");
int val = int.Parse(Console.ReadLine()!);

if (val == 10)
{
    Console.WriteLine($"Parabéns, você acertou !!!");
    Console.WriteLine($"O número {val} é igual a 10");
}
else
{
    if (val > 10)
    {
        Console.WriteLine($"Você errou !!!");
        Console.WriteLine($"O número {val} é maior que 10");
    }
    else
    {
        Console.WriteLine($"Você errou !!!");
        Console.WriteLine($"O número {val} é menor que 10");
    }
}

// Operadores lógicos
// - São operadores que geram resultados lógicos (true ou false) pela avaliação de expressões booleanas
// - Operadores lógicos são utilizados para combinar expressões booleanas
// - Operadores lógicos: && (AND), || (OR), ! (NOT)

// Operador AND (&&)
// - O operador AND (&&) é um operador binário
// - TODOS os termos da expressão devem ser verdadeiros para que o resultado seja verdadeiro
// - Se QUALQUER um dos termos for falso, o resultado será falso

// Operador OR (||)
// - O operador OR (||) é um operador binário
// - PELO MENOS UM dos termos da expressão deve ser verdadeiro para que o resultado seja verdadeiro
// - Somente se TODOS os termos forem falsos, o resultado será falso

// Operador NOT (!)
// - O operador NOT (!) é um operador unário
// - O operador NOT (!) inverte o valor lógico de uma expressão booleana

// Tabela verdade do operador AND (&&)

// | A | B | (A && B) |
// | v | v |    v   |
// | v | f |    f   |
// | f | v |    f   |
// | f | f |    f   |

// Tabela verdade do operador OR (||)

// | A | B | (A || B) |
// | v | v |    v     |
// | v | f |    v     |
// | f | v |    v     |
// | f | f |    f     |

// Tabela verdade do operador NOT (!)

// | A | !A  |
// | v |  f  |
// | f |  v  |

// Avalie o resultado das expressões abaixo, considerando as variáveis e seus valores

// a = 4, b=5, c=9, d=1;

// 1 - (( a != 0 ) && b == 5)
// 2 - ( a > 3 || d ==1 )
// 3 - !(( a > 3 || d < 3) && (b < c && d > c ))
// 4 - ( b ! = 0 || a > 4 ) || ( d < 3 && c >= 8)
// 5 - (( a > d || a << d) || a == ) || (!(b == 5 && b > c ))

// Dessa forma, podemos combinar expressões booleanas utilizando os operadores lógicos, simplificando e melhorando a legibilidade do código

// Exemplo 16 - Número positivo e par
Console.WriteLine($"Digite um número inteiro: ");
int val = int.Parse(Console.ReadLine()!);

if (val > 0)
{
    Console.WriteLine($"O número {val} é positivo");
}

if (val % 2 == 0)
{
    Console.WriteLine($"O número {val} é par");
}

// Obteremos o mesmo resultado utilizando o operador AND (&&)

if (val > 0 && val % 2 == 0)
{
    Console.WriteLine($"O número {val} é positivo e par");
}

Console.WriteLine($"\n===============================\n");

// Exemplo 17 - Número positivo e ímpar
Console.WriteLine($"Digite um número inteiro: ");
val = int.Parse(Console.ReadLine()!);

if (val > 0 && val % 2 != 0)
{
    Console.WriteLine($"O número {val} é positivo e ímpar");
}


// Exemplo 17v2 - Número positivo e ímpar
if (val > 0 && !(val % 2 == 0))
{
    Console.WriteLine($"O número {val} é positivo e ímpar");
}

// Exemplo 18 - Considere que será consedido um bonus ao trabalhadores de uma empresa, conforme salario atual do vendedor, descrito abaixo. Desenvolva um algoritmo para ler o salário e calcular o valor em reais do aumento, Exibir na tela, o salário atual, e o aumento em (% e R$) e o novo salário.

// Salário Atual | Aumento
// Até R$ 900,00 (inclusive) | 5%
// De R$ 900,00 a R$ 1.400,00 | 8%
// Acima de R$ 1.400,00 (inclusive) | 10%

double salario, aumento = 0;
Console.WriteLine($"Digite o salário: ");
salario = double.Parse(Console.ReadLine()!);

if (salario <= 900)
{
    aumento = salario * 0.05;
}
else if (salario > 900 && salario < 1400)
{
    aumento = salario * 0.08;
}
else
{
    aumento = salario * 0.10;
}

salario = salario + salario * (aumento / 100);
Console.WriteLine($"O aumento é de {aumento} porcento e o salário final é de {salario}");

Console.WriteLine($"\n===============================\n");

// Exemplo 19 - Dados três números, verificar se eles podem representar as medidas dos lados de um triângulo e, classificar o triângulo em equilátero, isósceles ou escaleno.

// Para que três números representem os lados de um triângulo é necessário que cada um deles seja menor que a soma dos outros dois.

// Um triângulo é equilátero se tem os três lados iguais,  isósceles se tem apenas dois lados iguais e escaleno se tem todos os lados distintos.

Console.WriteLine($"Digite o primeiro lado do triângulo: ");
double lado1 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o segundo lado do triângulo: ");
double lado2 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o terceiro lado do triângulo: ");
double lado3 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"");

if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
{
    Console.WriteLine("Os lados formam um triângulo");

    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("O triângulo é equilátero");
    }
    else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
    {
        Console.WriteLine("O triângulo é isósceles");
    }
    else
    {
        Console.WriteLine("O triângulo é escaleno");
    }
}
else
{
    Console.WriteLine("Os lados não formam um triângulo");
}
