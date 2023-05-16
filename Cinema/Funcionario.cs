using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Funcionario : Pessoa
    {
        int salario;
        string funcao;
        public Funcionario(string nome, string morada, int salario, string funcao) 
        {
            this.nome = nome;
            this.morada = morada;
            this.salario = salario;
            this.funcao = funcao;
        }
    }
}
