using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    internal class Filme
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int duracao { get; set; }
        public bool activo { get; set; }
        public Categoria categoria { get; set; }


        public override string ToString()
        {
            return "Titulo: " +nome + "  Minutos: " + duracao + "  Status: " + activo;
        }
    }
}
