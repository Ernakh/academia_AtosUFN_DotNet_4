Random gerador = new Random();
int[] vetorI = new int[5];

for (int i = 0; i < 5; i++)
{
    vetorI[i] = gerador.Next(10,50);
}

for (int i = 0; i < vetorI.Length; i++)
{
    Console.WriteLine(vetorI[i]);
}


