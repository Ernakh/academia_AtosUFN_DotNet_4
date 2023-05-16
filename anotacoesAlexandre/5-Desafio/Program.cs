using _5_Desafio;


List<Pessoa> listaPessoas = new List<Pessoa>();
Persistencia.popularArquivoLista("dados.dat", listaPessoas); //conectando com a base de dados

string opcao;
do {
    Console.Clear();
    Console.WriteLine("1 - Cadastrar pessoa");
    Console.WriteLine("2 - Listar pessoa");
    Console.WriteLine("3 - Pesquisar pessoa");
    Console.WriteLine("4 - Excluir pessoa");
    Console.WriteLine("5 - Sair");
    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            
            System.Console.WriteLine("Cadastrando pessoa");
            //rotina para cadastrar pessoa

            break;
        case "2":
            System.Console.WriteLine("Listando pessoas");
            //rotina para listar pessoas
            break;
        case "3":
            System.Console.WriteLine("Pesquisando pessoa");
            //rotina para pesquisar pessoa
            break;
        case "4":
            System.Console.WriteLine("Excluindo pessoa");
            //rotina para excluir pessoa
            break;
        case "5":
            System.Console.WriteLine("Obrigado por usar o sistema");
            break;
        default:
            System.Console.WriteLine("Opção inválida");
            break;
    }  
    Console.ReadKey();
} while(opcao != "5");
