using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaPOO
{
    class Caixa
    {
        private double Valor { get; set; }
        private double Saldo { get; set; }

        public Caixa()
        {
            this.Valor = 0;
            this.Saldo = 0;
        }

        public void Depositar(double v) 
        {
            if(v >= 0)
            {
                this.Saldo += v;
                Console.WriteLine($"Deposito de R${v} realizado com sucesso! ");
                Console.WriteLine($"Saldo Atual: R${Saldo}");
            }
            else
            {
                Console.WriteLine($"Não é possível depositar esse valor");
            }
        }

        public void Sacar(double v)
        {
            if(v >= 0 && v <= Saldo)
            {
                this.Saldo -= v;
                Console.WriteLine($"Saque de R${v} realizado com sucesso!");
                Console.WriteLine($"Saldo Atual: R${Saldo}");
            }
            else if(v >= 0 && v > Saldo)
            {
                Console.WriteLine($"Não é possível sacar R${v}, pois seu saldo é de R${Saldo}");
            }
            else
            {
                Console.WriteLine($"Valor de saque inválido");
            }
            
        }

    }
}
