/** 

Estrutura de repetição

- As estruturas de repetição são bastante importantes pois muitas vezes necessitamos repetir um bloco de código várias vezes.

- Existem 3 estruturas de repetição no C#:

    - while
    - do while
    - for

- A estrutura de repetição while é a mais simples de todas, pois ela executa um bloco de código enquanto uma condição for verdadeira.

- A estrutura de repetição do while é muito parecida com a estrutura de repetição while, a diferença é que a estrutura de repetição do while executa o bloco de código pelo menos uma vez, mesmo que a condição seja falsa.

- A estrutura de repetição for é a mais complexa de todas, pois ela executa um bloco de código enquanto uma condição for verdadeira, mas ela também permite que você defina uma variável de controle e que você defina o incremento ou decremento dessa variável.

- A estrutura de repetição for é muito utilizada quando você precisa repetir um bloco de código um número determinado de vezes.

*/

// Sintaxe da estrutura de repetição while

/*

while (condicao) {
    // bloco de código
}

// Sintaxe da estrutura de repetição do while
bool outraCondicao = true;

do {
    // bloco de código
} while (outraCondicao);

// Sintaxe da estrutura de repetição for

for (inicializacao; condicaoFor; incremento) {
    // bloco de código
}

*/

// Exemplo 02: Escreva um algoritmo que imprima todos os número de 0 a 10.

// Solução 01: Utilizando a estrutura de repetição while
int numero = 0;

while (numero <= 10)
{
    Console.WriteLine(numero);
    numero++;
}

// Solução 02: Utilizando a estrutura de repetição do while
numero = 0;

do
{
    Console.WriteLine(numero);
    numero++;
} while (numero <= 10);

// Solução 03: Utilizando a estrutura de repetição for
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

// Exemplo 04: Escreva um algoritm aque leia pelo teclado dois valores inteiros chamados inicio e fim, e imprima todos os números inteiros entre inicio e fim.

// Solução 01: Utilizando a estrutura de repetição while
Console.WriteLine("Digite o valor de inicio:");
int inicio = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de fim:");
int fim = int.Parse(Console.ReadLine());

while (inicio <= fim)
{
    Console.WriteLine(inicio);
    inicio++;
}

// Solução 02: Utilizando a estrutura de repetição do while

do
{
    Console.WriteLine(inicio);
    inicio++;
} while (inicio <= fim);

// Solução 03: Utilizando a estrutura de repetição for

for (int i = inicio; i <= fim; i++)
{
    Console.WriteLine(i);
}

// Controlando estruturas de repetição

// - O comando break é utilizado para interromper a execução de uma estrutura de repetição antes mesmo da condição ser falsa.

// - O comando continue é utilizado para interromper a execução de uma iteração antes mesmo da condição ser testada.

// Exemplo 05: Escreva um algoritma que leia continuamente o valor de entrada até que o usuário digite o valor 0.

// Solução 01: Utilizando a estrutura de repetição while
int valor = 0;

while (true)
{
    Console.WriteLine("While - Digite um valor qualquer ou 0 para encerrar o programa:");
    valor = int.Parse(Console.ReadLine()!);

    if (valor == 0)
    {
        break;
    }
}

// Solução 02: Utilizando a estrutura de repetição do while
valor = 0;

do
{
    Console.WriteLine("do While - Digite um valor qualquer ou 0 para encerrar o programa:");
    valor = int.Parse(Console.ReadLine()!);

    if (valor == 0)
    {
        break;
    }
} while (true);

// Solução 03: Utilizando a estrutura de repetição for
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("For - Digite um valor qualquer ou 0 para encerrar o programa:");
    valor = int.Parse(Console.ReadLine()!);

    if (valor == 0)
    {
        break;
    }
}

// Exemplo 09: Escreva um algoritmo que leia continuamente o valor de entrada do usuário, poré o programa só pode seguir sua execução caso o valor de opção seja entre 1 e 4, se o valor lido estiver entre 1 e 4 o programa deverá imprimir a mensagem "Valor inválido" e solicitar novamente o valor de entrada.

// Aplique o conceito de continue

// Solução 01: Utilizando a estrutura de repetição while
int opcao = 0;

while (true)
{
    Console.WriteLine("While - Digite um valor entre 1 e 4, caso queira sair digite 0:");
    opcao = int.Parse(Console.ReadLine()!);

    if (opcao <= 1 && opcao >= 4)
        continue;

    Console.WriteLine($"Você digitou o valor {opcao}");
}

// Solução 02: Utilizando a estrutura de repetição do while
opcao = 0;

do
{
    Console.WriteLine("do While - Digite um valor:");
    opcao = int.Parse(Console.ReadLine()!);

    if (opcao == 0)
        break;

    if (opcao <= 1 && opcao >= 4)
        continue;

    Console.WriteLine($"Você digitou o valor {opcao}");
} while (true);

// Solução 03: Utilizando a estrutura de repetição for

for (int i = 0; i < 100; i++)
{
    Console.WriteLine("For - Digite um valor:");
    opcao = int.Parse(Console.ReadLine()!);

    if (opcao == 0)
        break;

    if (opcao <= 1 && opcao >= 4)
        continue;

    Console.WriteLine($"Você digitou o valor {opcao}");
}