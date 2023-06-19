using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    internal class Cliente : Pessoa
    {
        public int numFiscal { get; set;  }
        public List<Bilhete> Bilhetes { get; set; }

        public override string ToString()
        {
            return nome + "  Morada: " + morada + " NIF:" + numFiscal;
        }
    }
}
