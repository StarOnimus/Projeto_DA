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
            DateTime dtaMIN = DateTime.Now.AddDays(1);
            dateTime.Value = dtaMIN;
            combo_filme.DataSource = FilmeController.GetFilmes();
            combo_sala.DataSource = SalaController.GetSala();
            listBox1.DataSource = SessaoController.GetSessoes();
        }

        private void FormSessao_Load(object sender, EventArgs e)
        {

        }

        private void add_sessao_Click(object sender, EventArgs e)
        {
            DateTime dtaMIN = DateTime.Now.AddDays(1);
            dateTime.Value = dtaMIN;
            SalaController.AddSessaoToSala(SessaoController.AddEditSessoes(preco.Text, dateTime.Value, (Filme)combo_filme.SelectedItem), (Sala)combo_sala.SelectedItem);
            listBox1.DataSource = SessaoController.GetSessoes();

            combo_filme.SelectedItem = null;
            combo_sala.SelectedItem=null;
            preco.Text = "";

            FormMain f1 = new FormMain();
            f1.update_list();

            MessageBox.Show("Sessaão adicionado/editado com sucesso", "Sucesso", MessageBoxButtons.OK);

        }

        private void del_sess_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Sessao ss = (Sessao)listBox1.SelectedItem;
                SessaoController.EliminarSessao(ss.id);
                listBox1.DataSource = SessaoController.GetSessoes();
                listBox1.ClearSelected();

                FormMain f1 = new FormMain();
                f1.update_list();
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

                var sessao = (Sessao)listBox1.SelectedItem;
            if (sessao != null)
            {
                preco.Text = sessao.preco.ToString();
            }
        }
    }
}
