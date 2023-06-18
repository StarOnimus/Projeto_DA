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
        public int fila { get; set; }
        public int coluna { get; set; }
        public string lugares { get; set; }
        public List<Sessao> sessoes { get; set; }

        public override string ToString()
        {
            return "Sala "+ nome;
        }


    }
}
