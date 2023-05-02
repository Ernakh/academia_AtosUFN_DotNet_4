// Vetores em C# (Arrays)

/**

Em C# os vetores são chamados de Arrays.

Arrays são estruturas de dados que permitem armazenar vários valores do mesmo tipo.

É util quando precisamos armazenar uma lista de valores.

A sintaxe para declarar um array é:

tipo[] nomeDoVetor;

Exemplo:

int[] numeros;

*/

// Vetores/Arrays unidimensionais

/**

Um array unidimensional é uma lista de valores do mesmo tipo.

É uma forma de armazenar vários valores do mesmo tipo em uma única variável, atraves de um índice.

O índice de um array começa em 0.

A sintaxe para declarar um array unidimensional é:

tipo[] nomeDoVetor = new tipo[tamanho];

Exemplo:

int[] numeros = new int[5];

Uma vez definido o tamanho do array, ele não pode ser alterado.
*/

// Manupulação de arrays

/**
Existem algumas formas de se atribuir valores a um array.

A primeira forma é atribuir valores diretamente na declaração do array.
*/

// Exemplo:
int[] numeros1 = new int[5] { 1, 2, 3, 4, 5 };

// A segunda forma é atribuir valores pelo índice do array.
// Exemplo:
int[] numeros2 = new int[5];
numeros2[0] = 1;
numeros2[1] = 2;
numeros2[2] = 3;
numeros2[3] = 4;
numeros2[4] = 5;

// A terceira forma é atribuir valores pelo índice do array, mas sem definir o tamanho do array.
// Exemplo:
int[] numeros3 = new int[] { 1, 2, 3, 4, 5 };

// A quarta forma é atribuir valores pelo índice do array, mas sem definir o tamanho do array e sem a palavra new.
// Exemplo:
int[] numeros4 = { 1, 2, 3, 4, 5 };

// A quinta forma é atribuir valores é pelo laço de repetição.
// Exemplo:
int[] numeros5 = new int[5];
for (int i = 0; i < numeros5.Length; i++)
{
    numeros5[i] = i + 1;
}





