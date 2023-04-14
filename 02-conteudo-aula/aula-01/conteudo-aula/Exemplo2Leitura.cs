namespace conteudo_aula.obj
{
    public class Exemplo2Leitura
    {
        public static void Main(string[] args)
        {
            int x;
            Console.WriteLine($"Digite um número: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou: {x}");
            
        }
    }
}