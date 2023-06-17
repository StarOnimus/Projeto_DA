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
            dateTimePicker1.MinDate = dtaMIN;
        }

        private void FormSessao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
