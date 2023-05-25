using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    internal class Cinema
    {
        public int id { get; set;  }
        public string nome { get; set; }
        public string morada { get; set; }
        public string email { get; set; }
        //"List<Sala> Sala" para varios         Sala Sala para 1
        public List<Sala> Sala { get; set; }

        public override string ToString()
        {
            return nome + " " + morada + " " + email;
        }
    }
}
