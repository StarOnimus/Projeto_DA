using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.Controller;
using Cinema.View;

namespace Cinema
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void cliente_Click(object sender, EventArgs e)
        {
            FormClientes gerir_clientes = new FormClientes();
            gerir_clientes.ShowDialog();
        }

        private void funcionarios_Click(object sender, EventArgs e)
        {
            FormFuncionarios gerir_funcionarios = new FormFuncionarios();
            gerir_funcionarios.ShowDialog();
        }

        private void cinema_Click(object sender, EventArgs e)
        {
            FormCinema gerir_cinemas = new FormCinema();
            gerir_cinemas.ShowDialog();
        }

        private void Sessao_Click(object sender, EventArgs e)
        {
            FormSessao gerir_sessao = new FormSessao();
            gerir_sessao.ShowDialog();
        }
    }
}
