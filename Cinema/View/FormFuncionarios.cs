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
    public partial class FormFuncionarios : Form
    {
        public FormFuncionarios()
        {
            InitializeComponent();
            listBox1.DataSource = FuncionarioController.GetFuncionarios();
        }

        private void add_fun_Click(object sender, EventArgs e)
        {
            FuncionarioController.AddEditFuncionarios(fun_name.Text, fun_morada.Text, fun_salario.Text, fun_funcao.Text);
            listBox1.DataSource = FuncionarioController.GetFuncionarios();
            listBox1.ClearSelected();
            MessageBox.Show("Funcionario adicionado/editado com sucesso", "Sucesso", MessageBoxButtons.OK);

            fun_name.Text = "";
            fun_morada.Text="";
            fun_salario.Text="";
            fun_funcao.Text = "";

        }

        private void del_fun_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Funcionario funcionario = (Funcionario)listBox1.SelectedItem;
                FuncionarioController.EliminarFuncionario(funcionario.id);
                listBox1.DataSource = FuncionarioController.GetFuncionarios();
                listBox1.ClearSelected();
                MessageBox.Show("Funcionario removido com sucesso", "Sucesso", MessageBoxButtons.OK);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            var funcionario = (Funcionario)listBox1.SelectedItem;
            if (funcionario != null)
            {
                fun_name.Text = funcionario.nome;
                fun_morada.Text = funcionario.morada;
                fun_salario.Text = funcionario.salario.ToString();
                fun_funcao.Text = funcionario.funcao;
            }
        }
    }
}
