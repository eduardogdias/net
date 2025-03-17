using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamentos_Polimorfismo
{
    abstract class Pagamento
    {
        protected double Valor { get; set; }
        public abstract void ProcessarPagamento();
    }
}
