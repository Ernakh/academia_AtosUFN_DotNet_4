/** 
    Matrizes ou Vetores2D

    Matrizes são vetores de vetores, ou seja, são vetores que possuem vetores como elementos.
    Possui duas dimensões, linhas e colunas.

    Exemplo:
    int[,] matriz = new int[3, 3];

            Coluna  Coluna  Coluna
    Linha   [0,0]   [0,1]   [0,2]
    Linha   [1,0]   [1,1]   [1,2]
    Linha   [2,0]   [2,1]   [2,2]

    Os índeces sempre iniciam em 0.

    Declaração:
    tipo[,] nome = new tipo[quantidade_linhas, quantidade_colunas];

    O elementos são referenciados da seguinte forma:
    nome[linha, coluna] = valor;

    Exemplo:
    matriz[0, 0] = 0;
    matriz[0, 1] = 1;
    matriz[0, 2] = 2;
    matriz[1, 0] = 10;
    matriz[1, 1] = 11;
    matriz[1, 2] = 12;
    matriz[2, 0] = 20;
    matriz[2, 1] = 21;
    matriz[2, 2] = 22;

    Manipulação:
    
    Para acessr um elemento da matrix, basta informar o índice da linha e da coluna.
    Exemplo:

    int valor = matriz[0, 0];

    Matriz podem ser manipuladas como uma variável comum, porém, é necessário informar o índice da linha e da coluna.

    Formas de Initializar uma Matriz:

    int[,] matriz = new int[3, 3];

    int[,] matriz = new int[3, 3] { { 0, 1, 2 }, { 10, 11, 12 }, { 20, 21, 22 } };

    int[,] matriz = { { 0, 1, 2 }, { 10, 11, 12 }, { 20, 21, 22 } };

    int[,] matriz = new int[,] { { 0, 1, 2 }, { 10, 11, 12 }, { 20, 21, 22 } };

    Percorrendo uma Matriz:

    Para percorrer uma matriz, é necessário utilizar dois laços de repetição, um para percorrer as linhas e outro para percorrer as colunas.

    Exemplo:

    for (int linha = 0; linha < matriz.GetLength(0); linha++)
    {
        for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
        {
            Console.WriteLine(matriz[linha, coluna]);
        }
    }
*/

// Exercício01 - Crie uma matriz do tipo int de tamanho 3x3;

int[,] matriz = new int[3, 3];

// Exercício02 - Crie uma matriz do tipo int de tamanho 3x3 e inicialize com os valores 0, 1, 2, 10, 11, 12, 20, 21, 22;
int[,] matriz01 = new int[3, 3];
matriz01[0, 0] = 0;
matriz01[0, 1] = 1;
matriz01[0, 2] = 2;
matriz01[1, 0] = 10;
matriz01[1, 1] = 11;
matriz01[1, 2] = 12;
matriz01[2, 0] = 20;
matriz01[2, 1] = 21;
matriz01[2, 2] = 22;

// Exercício03 - Crie uma matriz do tipo int de tamanho 3x3 e inicialize com os valores 0, 1, 2, 10, 11, 12, 20, 21, 22 utilizando a forma de inicialização de matrizes;
int[,] matriz02 = new int[3, 3]{
    { 0, 1, 2 },
    { 10, 11, 12 },
    { 20, 21, 22 }
};

// Exercício04 - Crie uma matriz do tipo int de tamanho 3x3 e inicialize com os valores 0, 1, 2, 10, 11, 12, 20, 21, 22 utilizando a forma de inicialização de matrizes e percorra a matriz utilizando o laço de repetição for imprimindo os valores no console;

int[,] matriz03 = new int[3, 3]{
    { 0, 1, 2 },
    { 10, 11, 12 },
    { 20, 21, 22 }
};

int linha = matriz03.GetLength(0);
int coluna = matriz03.GetLength(1);

for (int i = 0; i < linha; i++)
{
    for (int j = 0; j < coluna; j++)
    {
        Console.WriteLine($"[{i},{j}] = {matriz03[i, j]}");
    }
}
Console.WriteLine();

// Exercício04 - Crie uma matriz do tipo int de tamanho 3x3 e inicialize com os valores 0, 1, 2, 10, 11, 12, 20, 21, 22 utilizando a forma de inicialização de matrizes e percorra a matriz utilizando o laço de repetição for imprimindo apenas os valores no console em formato de tabela;

int[,] matriz04 = new int[3, 3]{
    { 0, 1, 2 },
    { 10, 11, 12 },
    { 20, 21, 22 }
};

linha = matriz04.GetLength(0);
coluna = matriz04.GetLength(1);

for (int i = 0; i < linha; i++)
{
    for (int j = 0; j < coluna; j++)
    {
        Console.Write($"{matriz04[i, j],4} |");
    }
    Console.WriteLine();
}



