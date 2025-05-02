using listas_exceptions;


    ListaDeCarro listaDeCarro = new ListaDeCarro();
    while (true)
    {
        Console.WriteLine("========= MENU =========");
        Console.WriteLine("1. Listar carros");
        Console.WriteLine("2. Adicionar carro");
        Console.WriteLine("3. Excluir carro");
        Console.WriteLine("4. Alterar carro");
        Console.WriteLine("5. Sair");
        Console.WriteLine("Escolha uma opção: ");
        int opcao;
        if(!int.TryParse(Console.ReadLine(), out opcao))
        {
            Console.WriteLine("Opção invpalida");
            continue;
        }

        switch (opcao)
        {
            case 1:
                listaDeCarro.ListarCarros();
                break;
            case 2:
                listaDeCarro.InserirCarro();
                break;
            case 3:
                listaDeCarro.ExcluirCarro();
                break;
            case 4:
                listaDeCarro.AlterarCarro();
                break;
            case 5:
                Console.WriteLine("Saindo do programa...");
                return;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
        Console.WriteLine("Digite qualquer tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
    }
