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
        }

        private void adicionar_sala_Click(object sender, EventArgs e)
        {

        }

        private void cinema_change_Click(object sender, EventArgs e)
        {
            CinemaController.AtualizarCinema();
        }
    }
}
