using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    internal class Bilhete
    {
        public int id { get; set; }
        public Cliente cliente { get; set; }
        public string lugar { get; set; }
        public bool activa { get; set; }
        public Funcionario funcionario { get; set; }
        public Sessao sessao { get; set; }

        public override string ToString()
        {
            return " " + activa;
        }
    }
}
