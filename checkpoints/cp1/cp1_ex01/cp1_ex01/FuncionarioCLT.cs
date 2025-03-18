using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp1_ex01
{
    class FuncionarioCLT : Funcionario
    {
        
        public double DescontoINSS { get; set; }

        public override double CalcularSalario()
        {
            return SalarioBase - (SalarioBase * DescontoINSS / 100);
        }
    }
}
