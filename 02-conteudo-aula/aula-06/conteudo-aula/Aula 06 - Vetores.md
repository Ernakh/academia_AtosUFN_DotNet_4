int[] vetor = new int[3];

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("Informe um valor para a posição " + i + ":");
    vetor[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine("O vetor possui na posição " + i + " o valor " + vetor[i]);
    Console.WriteLine("vetor[" + i + "] = " + vetor[i]);
}
