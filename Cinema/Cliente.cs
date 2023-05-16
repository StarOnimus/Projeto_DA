using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Cliente : Pessoa
    {
        int numFiscal;

        public Cliente(string nome, string morada, int numFiscal)
        {
            this.nome = nome;
            this.morada = morada;
            this.numFiscal = numFiscal;
        }

        public override string ToString()
        {
            return nome + " " + morada + " " + numFiscal;
        }
    }
}
