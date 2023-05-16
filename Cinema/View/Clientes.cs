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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            try {
                Cliente cliente = new Cliente(clienteNome.Text, clienteMorada.Text, Int32.Parse(clienteNumFisc.Text));
                listBox1.Items.Add(cliente.ToString());
            }
            catch (Exception) {
                MessageBox.Show("Dados invalidos!");
            }
        }
    }
}
