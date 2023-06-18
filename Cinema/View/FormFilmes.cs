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
    public partial class FormFilmes : Form
    {
        public FormFilmes()
        {
            InitializeComponent();
            CategoriaController.InicializacaoCategoria();
            combobox_categoria.DataSource = CategoriaController.GetCategorias();
            listBox1.DataSource = FilmeController.GetFilmes();

        }

        private void add_fc_Click(object sender, EventArgs e)
        {
            if (add_fc.Text == "Adicionar/Editar Filme")
            {
                FilmeController.AddEditFilmes(textbox_nome.Text, textbox_duracao.Text, checkBox1.Checked, (Categoria)combobox_categoria.SelectedItem);
                listBox1.DataSource = FilmeController.GetFilmes();
            }
            else 
            {
                CategoriaController.AddEditCategoria(textbox_nome.Text, checkBox1.Checked);
                listBox1.DataSource = CategoriaController.GetCategoriasTodas();
                combobox_categoria.DataSource = CategoriaController.GetCategorias();
            }
            textbox_nome.Text = string.Empty;
            textbox_duracao.Text = string.Empty;
            listBox1.ClearSelected();
        }

        private void change_categorias_Click(object sender, EventArgs e)
        {
            change_categorias.Enabled = false;
            change_filme.Enabled = true;
            label_duracao.Visible = false;
            textbox_duracao.Visible = false;
            combobox_categoria.Visible = false;
            label_nome.Text = "Nome da Categoria";
            add_fc.Text = "Adicionar/Editar Categoria";
            eliminar_fc.Text = "Eliminar Categoria";
            listBox1.DataSource = CategoriaController.GetCategoriasTodas();
            listBox1.ClearSelected();
        }

        private void change_filme_Click(object sender, EventArgs e)
        {
            change_categorias.Enabled = true;
            change_filme.Enabled = false;
            label_duracao.Visible = true;
            textbox_duracao.Visible = true;
            combobox_categoria.Visible = true;
            label_nome.Text = "Nome do Filme";
            add_fc.Text = "Adicionar/Editar Filme";
            eliminar_fc.Text = "Eliminar Filme";
            listBox1.DataSource = FilmeController.GetFilmes();
            combobox_categoria.DataSource = CategoriaController.GetCategorias();
            listBox1.ClearSelected();

        }

        private void eliminar_fc_Click(object sender, EventArgs e)
        {
            if (add_fc.Text == "Adicionar/Editar Filme")
            {
                if (listBox1.SelectedIndex != -1)
                {
                    Filme filme = (Filme)listBox1.SelectedItem;
                    FilmeController.EliminarFilme(filme.id);
                    listBox1.DataSource = FilmeController.GetFilmes();
                }
            }
            else
            {
                if (listBox1.SelectedIndex != -1)
                {
                    Categoria categoria = (Categoria)listBox1.SelectedItem;
                    CategoriaController.EliminarCategoria(categoria.id);
                    listBox1.DataSource = CategoriaController.GetCategoriasTodas();
                }
            }
            listBox1.ClearSelected();
            textbox_nome.Text = string.Empty;
            textbox_duracao.Text = string.Empty;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (add_fc.Text == "Adicionar/Editar Filme")
            {
                var filme = (Filme)listBox1.SelectedItem;
                if (filme != null)
                {
                    textbox_nome.Text = filme.nome;
                    textbox_duracao.Text = filme.duracao.ToString();
                    checkBox1.Checked = filme.activo;
                    //combobox_categoria.SelectedIndex = combobox_categoria.FindStringExact(filme.categoria.ToString());
                }
            }
            else
            {
                var categoria = (Categoria)listBox1.SelectedItem;
                if (categoria != null)
                {
                    textbox_nome.Text = categoria.nome;
                    checkBox1.Checked = categoria.activa;
                }
            }
            listBox1.ClearSelected();
        }
    }
}
