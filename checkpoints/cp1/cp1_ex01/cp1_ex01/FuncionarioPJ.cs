using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp1_ex01
{
    class FuncionarioPJ : Funcionario
    {
        public double TaxaImposto { get; set; }


        public override double CalcularSalario()
        {
            return SalarioBase - (SalarioBase * TaxaImposto / 100);
        }
    }
}
