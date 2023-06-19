namespace Cinema.View
{
    partial class FormFilmes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilmes));
            this.add_fc = new System.Windows.Forms.Button();
            this.eliminar_fc = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.textbox_nome = new System.Windows.Forms.TextBox();
            this.textbox_duracao = new System.Windows.Forms.TextBox();
            this.label_duracao = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.combobox_categoria = new System.Windows.Forms.ComboBox();
            this.change_filme = new System.Windows.Forms.Button();
            this.change_categorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_fc
            // 
            this.add_fc.Location = new System.Drawing.Point(9, 210);
            this.add_fc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_fc.Name = "add_fc";
            this.add_fc.Size = new System.Drawing.Size(191, 37);
            this.add_fc.TabIndex = 0;
            this.add_fc.Text = "Adicionar/Editar Filme";
            this.add_fc.UseVisualStyleBackColor = true;
            this.add_fc.Click += new System.EventHandler(this.add_fc_Click);
            // 
            // eliminar_fc
            // 
            this.eliminar_fc.Location = new System.Drawing.Point(9, 253);
            this.eliminar_fc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eliminar_fc.Name = "eliminar_fc";
            this.eliminar_fc.Size = new System.Drawing.Size(191, 37);
            this.eliminar_fc.TabIndex = 1;
            this.eliminar_fc.Text = "Eliminar Filme";
            this.eliminar_fc.UseVisualStyleBackColor = true;
            this.eliminar_fc.Click += new System.EventHandler(this.eliminar_fc_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(210, 14);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 277);
            this.listBox1.TabIndex = 2;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(16, 31);
            this.label_nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(77, 13);
            this.label_nome.TabIndex = 3;
            this.label_nome.Text = "Nome do filme:";
            // 
            // textbox_nome
            // 
            this.textbox_nome.Location = new System.Drawing.Point(19, 46);
            this.textbox_nome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textbox_nome.Name = "textbox_nome";
            this.textbox_nome.Size = new System.Drawing.Size(182, 20);
            this.textbox_nome.TabIndex = 4;
            // 
            // textbox_duracao
            // 
            this.textbox_duracao.Location = new System.Drawing.Point(19, 93);
            this.textbox_duracao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textbox_duracao.Name = "textbox_duracao";
            this.textbox_duracao.Size = new System.Drawing.Size(182, 20);
            this.textbox_duracao.TabIndex = 6;
            // 
            // label_duracao
            // 
            this.label_duracao.AutoSize = true;
            this.label_duracao.Location = new System.Drawing.Point(16, 78);
            this.label_duracao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_duracao.Name = "label_duracao";
            this.label_duracao.Size = new System.Drawing.Size(90, 13);
            this.label_duracao.TabIndex = 5;
            this.label_duracao.Text = "Duração do filme:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 124);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // combobox_categoria
            // 
            this.combobox_categoria.FormattingEnabled = true;
            this.combobox_categoria.Location = new System.Drawing.Point(19, 158);
            this.combobox_categoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combobox_categoria.Name = "combobox_categoria";
            this.combobox_categoria.Size = new System.Drawing.Size(182, 21);
            this.combobox_categoria.TabIndex = 9;
            // 
            // change_filme
            // 
            this.change_filme.Enabled = false;
            this.change_filme.Location = new System.Drawing.Point(9, 311);
            this.change_filme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.change_filme.Name = "change_filme";
            this.change_filme.Size = new System.Drawing.Size(220, 37);
            this.change_filme.TabIndex = 10;
            this.change_filme.Text = "Filmes";
            this.change_filme.UseVisualStyleBackColor = true;
            this.change_filme.Click += new System.EventHandler(this.change_filme_Click);
            // 
            // change_categorias
            // 
            this.change_categorias.Location = new System.Drawing.Point(262, 311);
            this.change_categorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.change_categorias.Name = "change_categorias";
            this.change_categorias.Size = new System.Drawing.Size(220, 37);
            this.change_categorias.TabIndex = 11;
            this.change_categorias.Text = "Categorias";
            this.change_categorias.UseVisualStyleBackColor = true;
            this.change_categorias.Click += new System.EventHandler(this.change_categorias_Click);
            // 
            // FormFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 362);
            this.Controls.Add(this.change_categorias);
            this.Controls.Add(this.change_filme);
            this.Controls.Add(this.combobox_categoria);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textbox_duracao);
            this.Controls.Add(this.label_duracao);
            this.Controls.Add(this.textbox_nome);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.eliminar_fc);
            this.Controls.Add(this.add_fc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormFilmes";
            this.Text = "FormFilmes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_fc;
        private System.Windows.Forms.Button eliminar_fc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textbox_nome;
        private System.Windows.Forms.TextBox textbox_duracao;
        private System.Windows.Forms.Label label_duracao;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox combobox_categoria;
        private System.Windows.Forms.Button change_filme;
        private System.Windows.Forms.Button change_categorias;
    }
}