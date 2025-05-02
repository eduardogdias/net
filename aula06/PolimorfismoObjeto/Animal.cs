using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoObjeto
{
    class Animal
    {
        public virtual void EmitirSom()
        {
            Console.WriteLine("Todo animal emite som");
        }
    }
}
