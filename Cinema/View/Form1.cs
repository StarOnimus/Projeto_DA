﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clientes_Click(object sender, EventArgs e)
        {
            Clientes gerir_clientes = new Clientes();
            gerir_clientes.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new CinemaContext())
            {
                listBox1.DataSource = db.Pessoas.ToList();

            }
        }
    }
}
