namespace conteudo_aula.obj
{
    public class Exemplo4
    {
        public static void Main(string[] args)
        {
            int idade1, idade2, diferenca;
            char letra1, letra2 = 'b';
            double valor1 = 5.788, valor2;

            letra1 = 'z';
            idade1 = 20;
            idade2 = 45;
            diferenca = idade2 - idade1;
            valor2 = valor1-2.088;

            Console.WriteLine($"este é o meu primeiro algoritmo com saída de dados na tela");
            Console.WriteLine($"a idade 1 é: " + idade1);
            Console.WriteLine($"a idade 2 é: " + idade2);
            Console.WriteLine($"a letra 1 é: " + letra1);
            Console.WriteLine($"a letra 2 é: " + letra2);
            Console.WriteLine($"o valor 1 é: " + valor1);
            Console.WriteLine($"o valor 2 é: " + valor2);
            Console.WriteLine($"a diferença do valor 1 para o valor 2 é: " + (valor1-valor2));
            Console.WriteLine($"a diferença das idades é: " + diferenca);
            Console.WriteLine($"a diferença das idades é: " + (idade2-idade1));
            Console.WriteLine("mostrando tudo: " + idade1 + " " + idade2 + " " + letra1 + " " + letra2 + " " + valor1 + " " + valor2 + " " + diferenca );
        }
    }
}