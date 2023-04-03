 ////Console.WriteLine("Escreva o seu nome:");

            //string NOME;//DECLARAÇÃO
            //string Nome;//DECLARAÇÃO
            //string nome;//DECLARAÇÃO // Case-Sensitive
            //            //nome = "Fabrício";//ATRIBUIÇÃO
            //Console.WriteLine("Escreva o seu nome:");
            //nome = Console.ReadLine();

            //Console.WriteLine("Seu nome é " + nome);//Com Concatenação

            // STRING
            string s;//texto, todo e qualquer texto
            char c;//caractere
            int x; //números inteiros
            long l;//números inteiros
            float y;//números reais
            double d;//números reais
            bool bo; //bool, bolleano, lógico - 0 ou 1 , true ou false

            //inteiros
            int idade = 32;
            //int a = 5;
            //int b = 2;

            double a;
            double b;

            Console.WriteLine("Digite um valor para A:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para B:");
            b = double.Parse(Console.ReadLine());


            Console.WriteLine("Sua idade é de " + idade + " anos");

            //int soma;
            //soma = a + b;
            //Console.WriteLine("A soma resulta em: " + soma);
            Console.WriteLine("A soma resulta em: " + (a + b));

            double sub = a - b;
            Console.WriteLine("A subtração resulta em: " + sub);

            double multi = a * b;
            double div = a / b;
            //double div = (double)a / (double)b;//CAST
            //double div = Convert.ToDouble(a) / Convert.ToDouble(b);//Convert
            //double div = 5f / 2f;//fixo
            Console.WriteLine("A multiplicação é: " + multi);
            Console.WriteLine("A divisão entre " + a + " e " + b + 
                " resulta em " + div);
