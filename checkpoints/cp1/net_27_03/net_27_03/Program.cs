using net_27_03;

static void Main(string[] args)
{
    ListaDeCarros listaDeCarros = new ListaDeCarros();
    while (true)
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1. Visualizar carros");
        Console.WriteLine("2. Adicionar carro");
        Console.WriteLine("3. Excluir carro");
        Console.WriteLine("4. Alterar carro");
        Console.WriteLine("5. Sair");
        int opcao;
        if(!int.TryParse(Console.ReadLine(), out opcao))
        {
            Console.WriteLine("Opção inválida. Por favor, ecolha uma opção válida");
            continue;

        }

        switch (opcao)
        {
            case 1:
                listaDeCarros.VisualizarCarros();
            case 2:
                listaDeCarros.AdicionarCarro();
            case 3:
                listaDeCarros.ExclurCarro();
            case 4:
                listaDeCarros.AlterarCarro();
            case 5:
                Console.WriteLine("Saindo do programa");
                return;
            case 6:
                Console.WriteLine("Opção invalida. Por favor, escolha uma opção valida");
                break;
        }
        Console.WriteLine("Digite qualquer tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
    }

}
