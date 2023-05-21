using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Sala
    {
        public string nome { get; set; }
        public int colunas { get; set; }

        public int filas { get; set; }

        public override string ToString()
        {
            return nome + " " + colunas + " " + filas;
        }
    }
}
