using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp1_ex02
{
    class Triangulo : FormaGeometrica
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }

        public double LadoC { get; set; }

        public override double CalcularArea()
        {
            double s = (LadoA + LadoB + LadoC) / 2;
            double area = Math.Sqrt((s * (s - LadoA) * (s - LadoB) * (s - LadoC)));
            return area;
        }

        public override double CalcularPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }
    }
}
