using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_27_03
{
    class ListaDeCarros
    {
        private List<Carro> carros = new List<Carro>();

        public void VisualizarCarros()
        {
            if (carros.Count == 0)
            {
                Console.WriteLine("Nenhum carro cadastrado");
            }
            else
            {
                Console.WriteLine("Carros cadastrados");
                for (int i = 0; i < carros.Count; i++)
                {
                    Console.WriteLine($"{i}. Marca: {carros[i].Marca}," +
                        $"Modelo: {carros[i].Modelo}," +
                        $"Ano: {carros[i].Ano}," +
                        $"Cor: {carros[i].Cor},");
                }
            }
        }

        public void AdicionarCarro()
        {
            try
            {            
                Console.WriteLine("Digite a marca do carro: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Digite a modelo do carro: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Digite o ano do carro: ");
                int ano = int.Parse(Console.ReadLine());

                if(ano < 1900 || ano > 9999)
                {
                    throw new ArgumentOutOfRangeException("Ano inválido.");
                }
                
                Console.WriteLine("Digite a cor do carro: ");
                string cor = Console.ReadLine();

                carros.Add(new Carro(marca, modelo, ano, cor));
                Console.WriteLine("Carro adicionado com sucesso");
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato de entrada invalid. Certifique de inserir um numero para o ano");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Erro: {ex}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex}");
            }
        }

        public void ExclurCarro()
        {
            VisualizarCarros();
            Console.WriteLine("Digite o número do carro que deseja excluir: ");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < carros.Count)
            {
                carros.RemoveAt(indice);
                Console.WriteLine("Carro removido com sucesso");
            }
            else
            {
                Console.Write("Indice inválido");
            }
        }


        public void AlterarCarro()
        {
            VisualizarCarros();
            Console.WriteLine("Digite o número do carro que deseja excluir: ");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < carros.Count)
            {
                Console.WriteLine("Digite a nova marca do carro: ");
                carros[indice].Marca = Console.ReadLine();


                Console.WriteLine("Digite o novo modelo do carro: ");
                carros[indice].Modelo = Console.ReadLine();

                Console.WriteLine("Digite o novo ano do carro: ");
                int novoAno;
                while (!int.TryParse(Console.ReadLine(), out novoAno))
                {
                    Console.WriteLine("Ano inválido. Digite novamente: ");
                }
                carros[indice].Ano = novoAno;

                Console.WriteLine("Digite a nova cor do carro: ");
                carros[indice].Cor = Console.ReadLine();

                Console.WriteLine("Carro alterado com sucesso");
            }
            else
            {
                Console.WriteLine("Indice inválido");
            }
        }
    }
}
