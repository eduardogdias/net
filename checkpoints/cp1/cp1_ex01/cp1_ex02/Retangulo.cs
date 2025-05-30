﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cp1_ex02
{
    class Retangulo : FormaGeometrica
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return Largura * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }
    }
}
