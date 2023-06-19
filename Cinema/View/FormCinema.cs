 using Cinema.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.Controller;

namespace Cinema.View
{
    public partial class FormCinema : Form
    {
        public FormCinema()
        {

            InitializeComponent();
            var cinema = CinemaController.GetCinema();
            listBox1.DataSource = SalaController.GetSala();

            if (cinema != null)
            {
                cinema_nome.Text = cinema.nome;
                cinema_morada.Text = cinema.morada;
                cinema_email.Text = cinema.email;
            }
            else
            {
                adicionar_sala.Enabled = false;
            }

           

        }

        private void adicionar_sala_Click(object sender, EventArgs e)
        {
            SalaController.AddSala(nomeSala_txt.Text, (int)CBnumeroColunas.Value, (int)CBnumeroFilas.Value);
            CinemaController.AddToList(nomeSala_txt.Text);
            listBox1.DataSource = SalaController.GetSala();
        }

        private void cinema_change_Click(object sender, EventArgs e)
        {
            CinemaController.AtualizarCinema(cinema_nome.Text, cinema_morada.Text, cinema_email.Text);
            adicionar_sala.Enabled = true;
            MessageBox.Show("Cinema adicionado/editado com sucesso", "Sucesso",MessageBoxButtons.OK);
            cinema_nome.Text = "";
            cinema_morada.Text = "";
            cinema_email.Text = "";

        }

        private void dataGridViewLugares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int selectedRow = e.RowIndex;
            int selectedColumn = e.ColumnIndex;

            MessageBox.Show($"Posição selecionada: ({selectedRow}, {selectedColumn})");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            var sala = (Sala)listBox1.SelectedItem;
            if (sala != null)
            {
                nomeSala_txt.Text = sala.nome;

            }
        }

        private void editar_sala_Click(object sender, EventArgs e)
        {

        }

        private void eliminar_sala_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Sala sala = (Sala)listBox1.SelectedItem;
                SalaController.EliminarSala(sala.id);
                listBox1.DataSource = SalaController.GetSala();
                listBox1.ClearSelected();
                MessageBox.Show("Sala removido com sucesso", "Sucesso", MessageBoxButtons.OK);
            }
        }
    }
}
