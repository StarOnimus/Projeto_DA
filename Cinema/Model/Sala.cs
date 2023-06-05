﻿using System;
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
        public int[,] lugar { get; set; }
        public List<Sessao> Sessoes { get; set; }
        public override string ToString()
        {
            return nome + " " + lugar;
        }
    }
}
