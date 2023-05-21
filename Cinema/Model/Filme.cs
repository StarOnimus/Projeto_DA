using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    internal class Filme
    {
        public string nome { get; set; }
        public int duracao { get; set; }
        public bool activo { get; set; }


        public override string ToString()
        {
            return nome + " " + duracao + " " + activo;
        }
    }
}
