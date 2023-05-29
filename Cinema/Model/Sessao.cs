using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    internal class Sessao
    {
        public int id { get; set; }
        public DateTime dtaHora { get; set; }
        public float preco { get; set; }
        public List<Bilhete> Bilhetes { get; set; }
        public Filme Filme { get; set; }

        public override string ToString()
        {
            return dtaHora + " " + preco;
        }
    }
}
