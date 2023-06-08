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

namespace Cinema
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            listBox1.DataSource = ClienteController.GetClientes(); 
            listBox1.ClearSelected();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            ClienteController.AddEditClientes(clienteNome.Text, clienteMorada.Text, clienteNumFisc.Text);
            listBox1.DataSource = ClienteController.GetClientes();
            listBox1.ClearSelected();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) {
                Cliente cliente = (Cliente)listBox1.SelectedItem;
                ClienteController.EliminateClientes(cliente.id);
                listBox1.DataSource = ClienteController.GetClientes();
                listBox1.ClearSelected();
            }
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            clienteNome.Text = null;
            clienteMorada.Text = null;
            clienteNumFisc.Text = null;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var cliente = (Cliente)listBox1.SelectedItem;
            if (cliente != null)
            {
                clienteNome.Text = cliente.nome;
                clienteMorada.Text = cliente.morada;
                clienteNumFisc.Text = cliente.numFiscal.ToString();
            }
        }
    }
}
