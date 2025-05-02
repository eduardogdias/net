using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoObjeto
{
    class Calculadora
    {
        public int Soma(int a, int b)
        {
            return a + b;
        }

        public int Somar(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Somar(double a, double b)
        {
            return a+b;
        }
    }
}
