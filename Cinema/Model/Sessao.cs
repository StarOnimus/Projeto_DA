using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    internal class Sessao
    {
        public string dtaHora { get; set; }
        public string preco { get; set; }


        public override string ToString()
        {
            return dtaHora + " " + preco;
        }
    }
}
