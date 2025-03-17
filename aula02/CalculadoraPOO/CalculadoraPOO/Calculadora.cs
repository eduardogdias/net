using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp1
{
    class Calculadora
    {
        //atributo
        public double n1 { get; set; }
        public double n2 { get; set; }
        public double res { get; set; }

        //construtores
        public Calculadora()
        {
            this.n1 = 0;
            this.n2 = 0;
            this.res = 0;
        }
        public Calculadora(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public void Somar()
        {
            this.res = n1 + n2;
        }

        public double Subtrair()
        {
            return this.n1 - this.n2;
        }

        public void Multiplicar(double a, double b)
        {
            this.res = a * b;
        }

        public double Dividir(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Divisão por zero n dá");
                return 0;
            }
        }
    }
}
