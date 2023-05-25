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
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            ClienteController.AddClientes(clienteNome.Text, clienteMorada.Text, Int32.Parse(clienteNumFisc.Text));
            listBox1.DataSource = ClienteController.GetClientes();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listBox1.SelectedItem;
            ClienteController.EliminateClientes(cliente.id);
            listBox1.DataSource = ClienteController.GetClientes();
        }
    }
}
