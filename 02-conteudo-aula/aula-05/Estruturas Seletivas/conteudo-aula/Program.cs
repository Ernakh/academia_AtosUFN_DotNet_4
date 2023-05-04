// Estruturas seletivas

/**

Switch case

- Comumente chamada de "swtich" ou "swtich statement", é uma estrutura de seleção múltipla.

- Estrutura de seleção múltipla

- A estrutura de seleção múltipla switch case é utilizada quando você precisa testar uma variável para verificar se ela é igual a um valor específico.

- Sintaxe:

switch (variavel) {
    case valor1:
        // bloco de código
        break;
    case valor2:
        // bloco de código
        break;
    case valor3:
        // bloco de código
        break;
    default:
        // bloco de código
        break;
}

Obs.: O bloco de código do default será executado caso nenhum dos valores testados seja igual ao valor da variável.
 */

// Exemplo 03: Implemente uma calculadora simples utilizando a estrutura de seleção múltipla switch case, com os operadores "+", "-", "*" e "/".

// Solução 01: Utilizando a estrutura de seleção múltipla switch case

Console.WriteLine("Digite o primeiro número:");
double primeiroNumero = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digite o segundo número:");
double segundoNumero = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digite o operador:");
string operador = Console.ReadLine()!;

double resultado = 0;

switch (operador)
{
    case "+":
        resultado = primeiroNumero + segundoNumero;
        break;
    case "-":
        resultado = primeiroNumero - segundoNumero;
        break;
    case "*":
        resultado = primeiroNumero * segundoNumero;
        break;
    case "/":
        resultado = primeiroNumero / segundoNumero;
        break;
    default:
        Console.WriteLine("Operador inválido!");
        break;
}

Console.WriteLine($"O resultado da operação é: {resultado}");

/**

Operador ternário -> ?

- O operador ternário é um operador condicional que permite que você faça uma atribuição de valor com base em uma condição.

- É umas sintaxe simplificada da estrutura de seleção simples if-else.

- Sintaxe:

variavel = (condicao) ? valorSeVerdadeiro : valorSeFalso;

 */


// Exemplo 04: Leia um número inteiro e imprima se ele é par ou ímpar.
// Solução 01: Utilizando operator ternário

Console.WriteLine("Digite um número inteiro para testa se é Par ou Ímpar:");
int numero = int.Parse(Console.ReadLine()!);

string resultadoTexto = (numero % 2 == 0) ? "par" : "ímpar";

Console.WriteLine($"O número digitado é {resultadoTexto}.");


/**

Operador switch expression

- A partir da versão 8 do C#, foi adicionado o operador switch expression, que é uma sintaxe simplificada da estrutura de seleção múltipla switch case.

- Sintaxe:

variavel = variavel switch {
    valor1 => instrucao1,
    valor2 => instrucao2,
    valor3 => instrucao3,
    _ => valorPadrao
};

Obs.: O bloco de código do _ será executado caso nenhum dos valores testados seja igual ao valor da variável.
*/

// Exemplo 05: Implemente uma calculadora simples utilizando o operador ternário, com os operadores "+", "-", "*" e "/".

Console.WriteLine("Digite o primeiro número:");
primeiroNumero = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digite o segundo número:");
segundoNumero = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digite o operador:");
operador = Console.ReadLine()!;

double resultadoOperacao = operador switch
{
    "+" => primeiroNumero + segundoNumero,
    "-" => primeiroNumero - segundoNumero,
    "*" => primeiroNumero * segundoNumero,
    "/" => primeiroNumero / segundoNumero,
    _ => 0
};

Console.WriteLine($"O resultado da operação é: {resultadoOperacao}");

/** A expressão switch é uma nova sintaxe introduzida no C# 8.0 que permite que você use uma expressão switch como uma expressão em vez de uma instrução. Isso significa que você pode usar a expressão switch em qualquer lugar onde você possa usar uma expressão, como em uma atribuição de variável, em um retorno de método ou como um argumento de método.

Além disso, a expressão switch suporta correspondência de padrões, o que permite que você teste se uma expressão corresponde a um padrão específico e execute diferentes ações com base no resultado da correspondência. Isso pode tornar seu código mais legível e conciso ao lidar com tipos complexos de dados.

Por exemplo, aqui está um exemplo de como você pode usar a expressão switch com correspondência de padrões para verificar se uma variável é um número inteiro par ou ímpar:
*/

Console.WriteLine($"Digite um número inteiro para ser testado na \"switch expression\" se é Par ou Ímpar:");
int numeroParOuImpar = int.Parse(Console.ReadLine()!);

string resultadoParOuImpar = numeroParOuImpar switch
{
    int n when n % 2 == 0 => "Par",
    int n when n % 2 != 0 => "Ímpar",
    _ => "Não é um número inteiro"
};

Console.WriteLine($"{resultadoParOuImpar}");