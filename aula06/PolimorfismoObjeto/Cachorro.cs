using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoObjeto
{
    class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O cachorro late");
        }
    }
}
