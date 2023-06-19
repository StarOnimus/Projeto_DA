using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cinema.Model
{
    internal class Funcionario : Pessoa
    {
        public int salario { get; set; }
        public string funcao { get; set; }
        public List<Bilhete> Bilhetes { get; set; }

        public override string ToString()
        {
            return "Nome: "+ nome + " Função: " + funcao;
        }
    }
}
