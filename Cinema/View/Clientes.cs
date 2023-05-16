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
                using (var db = new CinemaContext())
                {
                    var cl = new Cliente { nome = clienteNome.Text, morada = clienteMorada.Text, numFiscal = Int32.Parse(clienteNumFisc.Text) };
                    db.Clientes.Add(cl);
                    db.SaveChanges();
                    listBox1.Items.Add(cl.ToString());
                }
            }
            catch (Exception x) {
                MessageBox.Show(x.ToString());
            }
        }
    }
}
