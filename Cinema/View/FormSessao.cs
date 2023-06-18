using Cinema.Controller;
using Cinema.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.View
{
    public partial class FormSessao : Form
    {
        public FormSessao()
        {
            InitializeComponent();
            DateTime dtaMIN = DateTime.Today.AddDays(1);
            dateTime.MinDate = dtaMIN;
            combo_filme.DataSource = FilmeController.GetFilmes();
            combo_sala.DataSource = SalaController.GetSala();
        }

        private void FormSessao_Load(object sender, EventArgs e)
        {

        }

        private void add_sessao_Click(object sender, EventArgs e)
        {
            SessaoController.AddEditSessoes(preco.Text, dateTime.Value, (Filme)combo_filme.SelectedItem);
            SalaController.AddSessaoToSala(dateTime.Value, combo_sala.SelectedItem.ToString(), (Filme)combo_filme.SelectedItem);
            listBox1.DataSource = SessaoController.GetSessoes();
        }
    }
}
