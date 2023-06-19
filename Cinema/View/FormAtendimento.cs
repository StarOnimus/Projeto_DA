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
    public partial class FormAtendimento : Form
    {
        public FormAtendimento(object ss)
        {
            InitializeComponent();
            Sessao sessao = (Sessao)ss;
            if (sessao != null)
            {
                Sala sala = SalaController.ReturnSalaFromSessao(sessao);

                dataGridView1.ColumnCount = sala.coluna;
                dataGridView1.RowCount = sala.fila;

                int value = 0;

                for (int row = 0; row < sala.fila; row++)
                {
                    for (int col = 0; col < sala.coluna; col++)
                    {
                        dataGridView1[col, row].Value = row + " " + col;
                        if (sala.lugares[value].ToString() == "0")
                        {
                            dataGridView1.Rows[row].Cells[col].Style.BackColor = Color.Gray;
                        }
                        else
                        {
                            dataGridView1.Rows[row].Cells[col].Style.BackColor = Color.Green;
                        }
                        value++;
                    }
                }

            }
        }

        private void criar_bilhete_Click(object sender, EventArgs e)
        {
            foreach (DataGridCell cell in dataGridView1.SelectedCells) 
            {
                MessageBox.Show(cell.ToString());
            }
        }
    }
}
