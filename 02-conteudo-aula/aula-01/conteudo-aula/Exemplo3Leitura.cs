namespace conteudo_aula.obj
{
    public class Exemplo3Leitura
    {
        public static void Main(string[] args)
        {
            int x;
            char ch;
            double n2;

            Console.WriteLine($"Digite um número inteiro: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite uma letra: ");
            ch = char.Parse(Console.ReadLine());

            Console.WriteLine($"Digite um número, podeser com decimal: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Você digitou o número: {x}");
            Console.WriteLine($"Você digitou a letra: {ch}");
            Console.WriteLine($"Você digitou o número: {n2}");

        }
    }
}