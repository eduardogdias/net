using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp1_ex02
{
    class Circulo : FormaGeometrica
    {
        public double Raio { get; set; }

        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }
    }
}
