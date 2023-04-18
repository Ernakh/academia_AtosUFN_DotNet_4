using System.Runtime.Serialization;

namespace Funcoes
{
    internal class Program
    {
        public static double subtrai(double num1, double num2)
        {
            double resultado;
            resultado = num1 - num2;
            return resultado;
        }
        public static void soma(double num1, double num2)
        {
            double resultado;
            resultado = num1 + num2;
            Console.WriteLine(num1+"+"+num2+"="+resultado);
        }
        public static double divide(double num1, double num2)
        {
            double resultado;
            resultado = num1 / num2;
            return resultado;
        }
        public static double multiplica(double num1 , double num2)
        {
            double resultado;
            resultado = num1 * num2;
            return resultado;
        }

        public static bool verificaPar(double numero)
        {
            if (numero % 2 == 0)
                return true;
            else
                return false;
        }


        static void Main(string[] args)
        {
            double n1, n2, res;
            Console.WriteLine("Digite dois numeros: ");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());

            soma(n1, n2);

            res = subtrai(n1, n2);
            Console.WriteLine(n1 + "-" + n2 + "=" + res);

            res = multiplica(n1,n2);
            Console.WriteLine(n1+"*"+n2+"="+res);

            Console.WriteLine(n1 + "/" + n2 + "=" + divide(n1,n2));


            if (verificaPar(n1)) 
                Console.WriteLine("Par");
            else
                Console.WriteLine("Impar");


            if(verificaPar(n2))
                Console.WriteLine("Par");
            else
                Console.WriteLine("Impar");
        }

    }
}