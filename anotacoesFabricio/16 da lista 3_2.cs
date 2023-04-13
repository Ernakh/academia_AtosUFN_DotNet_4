int n;
            do
            {
                Console.WriteLine("informe um valor menor ou igual a 50");
                n = int.Parse(Console.ReadLine());

            } while (n > 50);

            while (n < 250)//tratar o zero tbm
            {
                n *= 3; //n = n*3;
            }

            Console.WriteLine(n);
