using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamentos_Polimorfismo
{
    class PagamentoBoleto : Pagamento
    {
        public override void ProcessarPagamento()
        {
            Console.WriteLine("Pagamento realizado no Boleto");
        }
    }
}
