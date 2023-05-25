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
        public string nome { get; set; }
        public bool activa { get; set; }


        public override string ToString()
        {
            return nome + " " + activa;
        }
    }
}
