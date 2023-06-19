using Cinema.Controller;
using Cinema.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cinema.View
{
    public partial class FormAtendimento : Form
    {
        public FormAtendimento(object ss)
        {
            InitializeComponent();
            comboBox1.DataSource = ClienteController.GetClientes();
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

            FormMain f1 = new FormMain();
            foreach (DataGridViewTextBoxCell cell in dataGridView1.SelectedCells)
            {
                if (dataGridView1.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Style.BackColor == Color.Gray)
                {
                    AtendimentoController.CreateBilhetes((Cliente)comboBox1.SelectedItem, cell.RowIndex, cell.ColumnIndex, true, (Funcionario)f1.combo_funci.SelectedItem, (Sessao)f1.listBox1.SelectedItem);
                    dataGridView1.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Style.BackColor = Color.Green;
                    Sala sl = SalaController.ReturnSalaFromSessao((Sessao)f1.listBox1.SelectedItem);

                    int value = 0;
                    for (int row = 0; row < cell.RowIndex; row++)
                    {
                        for (int col = 0; col < cell.ColumnIndex; col++)
                        {
                            value++;
                        }
                    }
                    MessageBox.Show(value.ToString());
                    SalaController.ocupado(sl, value);
                }
            }
        }
    }
}
