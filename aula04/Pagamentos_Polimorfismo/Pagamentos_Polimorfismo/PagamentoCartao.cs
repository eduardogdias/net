using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamentos_Polimorfismo
{
    class PagamentoCartao : Pagamento
    {
        public override void ProcessarPagamento()
        {
            Console.WriteLine("Pagamento realizado no Cartão");
        }

        public void ProcessarPagamento(int parcelas)
        {
            Console.WriteLine($"Pagamento realizado no Cartão em {parcelas}x");
        }
    }
}
