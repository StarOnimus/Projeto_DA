using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    internal class Sala
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int[,] lugar { get; set; }
        public int numeroDeLugares { get; set; }
        public List<Sessao> sessoes { get; set; }

        public override string ToString()
        {
            return "Sala "+ nome + " Nªlugares " + lugar + numeroDeLugares;
        }
        public int[,] lugares()
        {
            return lugar;
        }

    }
}
