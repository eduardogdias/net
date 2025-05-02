using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas_exceptions
{
    class ListaDeCarro
    {
        private List<Carro> carros = new List<Carro>();

        // 1 - listar
        public void ListarCarros()
        {
            if (carros.Count == 0)
            {
                Console.WriteLine("Nenhum carro cadastrado");
            }
            else
            {
                Console.WriteLine("Carros cadastrados:");
                for(int i = 0; i < carros.Count; i++)
                {
                    Console.WriteLine($"{i}. Marca: {carros[i].Marca} - " +
                        $"Modelo: {carros[i].Modelo} -" +
                        $"Ano: {carros[i].Ano} - " +
                        $"Cor: {carros[i].Cor}");
                }
            }
        }


        // 2 - inserir carro
        public void InserirCarro()
        {
            try
            {
                Console.WriteLine("Digite a Marca: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Digite o Modelo: ");
                string modelo = Console.ReadLine();

                Console.WriteLine("Digite o Ano: ");
                int ano;
                // tente converter para inteiro o ReadLine, se der certo
                // a conversão vai pra saida que é a variavel
                while(!int.TryParse(Console.ReadLine(), out ano))
                {
                    Console.WriteLine("Ano inválido. Digite novamente: ");
                }

                Console.WriteLine("Digite a Cor: ");
                string cor = Console.ReadLine();


                carros.Add(new Carro(marca, modelo, ano, cor));
                Console.WriteLine("Carro adicionado com sucesso!");
            }
            catch (FormatException){
                Console.WriteLine("Erro: Formato de entrada Inválido.");
            }
            catch(ArgumentOutOfRangeException ex){
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch(Exception ex){
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }


        // 3 - excluir carro
        public void ExcluirCarro()
        {
            ListarCarros();
            Console.WriteLine("Digite o número do carro que deseja excluir: ");
            if(int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < carros.Count){
                carros.RemoveAt(indice);
                Console.WriteLine("Carro removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Íncide inválido. Não foi possível excluir o carro");
            }
        }


        // 4 - alterar carro
        public void AlterarCarro()
        {
            ListarCarros();
            Console.WriteLine("Digite o número do carro que deseja alterar: ");
            if(int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < carros.Count)
            {
                Console.WriteLine("Digite a nova Marca: ");
                carros[indice].Marca = Console.ReadLine();
                Console.WriteLine("Digite o novo Modelo: ");
                carros[indice].Modelo = Console.ReadLine();


                Console.WriteLine("Digite o novo Ano: ");
                int novoAno;
                while (!int.TryParse(Console.ReadLine(), out novoAno))
                {
                    Console.WriteLine("Ano inválido. Digite novamente: ");
                }
                carros[indice].Ano = novoAno;

                Console.WriteLine("Digite a nova Cor: ");
                carros[indice].Cor = Console.ReadLine();

                Console.WriteLine("Carro alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("Índice inválido");
            }

        }
    }
}
