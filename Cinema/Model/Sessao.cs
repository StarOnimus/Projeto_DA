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
        public Filme filme { get; set; }

        public override string ToString()
        {
            return "ID: "+ id.ToString() + " Horario: " + dtaHora + " Preço: " + preco +" €";
        }
    }
}
