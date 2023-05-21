using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Cliente : Pessoa
    {
        public int numFiscal { get; set;  }

        public override string ToString()
        {
            return nome + " " + morada + " " + numFiscal;
        }
    }
}
