/* 1) Crie uma Matriz 5x3. Na primeira coluna,
 solicite que o usuário preencha.
 A 2ª coluna, some 10 aos elementos da
 1ª coluna. Na 3º coluna, armazene o dobro
 dos elementos da 1ª coluna.

// 5   15   10   
// 3   0   0
// 2   0   0
// 6   0   0
// 4   0   0

// 0,0   0,1   0,2   
// 1,0   1,1   1,2
// 2,0   2,1   2,2
// 3,0   3,1   3,2
// 4,0   4,1   4,2

//padrão de preenchimento de matrizes: linha X coluna

//declaracao
int[,] matriz = new int[5,3];

for (int linha = 0; linha < 5; linha++)
{
    Console.Write("Digite um valor para a primeira coluna: ");
    matriz[linha, 0] = int.Parse( Console.ReadLine() );
    matriz[linha, 1] = matriz[linha, 0] + 10;
    matriz[linha, 2] = matriz[linha, 0] * 2;
}

for (int linha = 0; linha < 5; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++ )
    {
        Console.Write(matriz[linha, coluna] + "\t");
    }
    Console.WriteLine();    
}

*/

/*2) Solicite ao usuário, preencher uma Matriz 3x3

Informe ao usuário:
*A soma dos elementos de cada linha
	-Ex: Linha 1: 30

         Linha 2: 17
* A soma dos elementos de cada coluna
	-Ex: Coluna 1: 23

         Coluna 2: 36
*/

int[,] matriz = new int[2, 3];
Console.WriteLine(matriz.GetLength(0)); //mostra qtas linhas ha
Console.WriteLine(matriz.GetLength(1)); //mostra qtas colunas ha

Console.WriteLine("Preencha a matriz 2x3!!");

for (int linha = 0; linha < matriz.GetLength(0); linha++)
{
    for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
    {
        Console.Write("Posicao[" + linha + "," + coluna + "]: ");
        matriz[linha,coluna] = int.Parse( Console.ReadLine() );
    }
}

//exibir a matriz
for (int linha = 0; linha < matriz.GetLength(0); linha++)
{
    for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
    {
        Console.Write(matriz[linha, coluna] + "\t");
    }
    Console.WriteLine();
}

int soma;
//calcular e mostrar a soma de linha a linha
for (int linha = 0; linha < matriz.GetLength(0); linha++)
{
    soma = 0;
    for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
    {
        soma = soma + matriz[linha, coluna];
    }
    Console.WriteLine("A soma dos elementos da linha " + linha + ": " + soma);
}


//calcular e mostrar a soma de coluna a coluna
for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
{
    soma = 0;
    for (int linha = 0; linha < matriz.GetLength(0); linha++)
    {
        soma = soma + matriz[linha, coluna];
    }
    Console.WriteLine("A soma dos elementos da coluna " + coluna + ": " + soma);
}





