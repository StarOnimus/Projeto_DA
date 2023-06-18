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

            if ( cinema != null ) {
                cinema_nome.Text = cinema.nome;
                cinema_morada.Text = cinema.morada;
                cinema_email.Text = cinema.email;
            }

           

        }

        private void adicionar_sala_Click(object sender, EventArgs e)
        {
            SalaController.AddSala(nomeSala_txt.Text, (int)CBnumeroColunas.Value, (int)CBnumeroFilas.Value);
            listBox1.DataSource = SalaController.GetSala();
        }

        private void cinema_change_Click(object sender, EventArgs e)
        {
            CinemaController.AtualizarCinema(cinema_nome.Text, cinema_morada.Text, cinema_email.Text);
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
            if (listBox1.SelectedItem != null)
            {
                Sala salaSelecionada = (Sala)listBox1.SelectedItem;

                dataGridViewLugares.ColumnCount = salaSelecionada.coluna;
                dataGridViewLugares.RowCount = salaSelecionada.fila;

                int value = 0;

                for (int row = 0; row < salaSelecionada.fila; row++)
                {
                    for (int col = 0; col < salaSelecionada.coluna; col++)
                    {
                        dataGridViewLugares[col, row].Value = salaSelecionada.lugares[value];
                        value++;
                    }
                }

            }
        }
    }
}
