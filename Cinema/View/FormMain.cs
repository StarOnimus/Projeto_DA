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
using Cinema.Model;
using Cinema.View;

namespace Cinema
{
    public partial class FormMain : Form
    {
        object sessao;
        public FormMain()
        {
            InitializeComponent();
            listBox1.DataSource = SessaoController.GetSessoes();
            combo_funci.DataSource = FuncionarioController.GetFuncionarios();
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

        private void add_filme_Click(object sender, EventArgs e)
        {
            FormFilmes gerir_filmes = new FormFilmes();
            gerir_filmes.ShowDialog();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sessao = listBox1.SelectedItem;
            if (sessao != null)
            {
                FormAtendimento criar_bilhete = new FormAtendimento(sessao);
                criar_bilhete.ShowDialog();
            }
        }
    }
}
