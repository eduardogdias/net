using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp1_ex01
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBase { get; set; }

        public virtual double CalcularSalario()
        {
            return SalarioBase;
        }

    }
}
