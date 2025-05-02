using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_27_03
{
    class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }

        public Carro(string marca, string modelo, int ano, string cor)
        {
            this. Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Cor = cor;
        }
    }
}
