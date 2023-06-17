namespace Cinema.View
{
    partial class FormCinema
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
            this.cinema_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cinema_morada = new System.Windows.Forms.TextBox();
            this.cinema_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.adicionar_sala = new System.Windows.Forms.Button();
            this.editar_sala = new System.Windows.Forms.Button();
            this.eliminar_sala = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nomeSala_txt = new System.Windows.Forms.TextBox();
            this.CBnumeroColunas = new System.Windows.Forms.NumericUpDown();
            this.CBnumeroFilas = new System.Windows.Forms.NumericUpDown();
            this.cinema_change = new System.Windows.Forms.Button();
            this.dataGridViewLugares = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CBnumeroColunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBnumeroFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLugares)).BeginInit();
            this.SuspendLayout();
            // 
            // cinema_nome
            // 
            this.cinema_nome.Location = new System.Drawing.Point(18, 31);
            this.cinema_nome.Margin = new System.Windows.Forms.Padding(2);
            this.cinema_nome.Name = "cinema_nome";
            this.cinema_nome.Size = new System.Drawing.Size(252, 20);
            this.cinema_nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Morada";
            // 
            // cinema_morada
            // 
            this.cinema_morada.Location = new System.Drawing.Point(18, 73);
            this.cinema_morada.Margin = new System.Windows.Forms.Padding(2);
            this.cinema_morada.Name = "cinema_morada";
            this.cinema_morada.Size = new System.Drawing.Size(252, 20);
            this.cinema_morada.TabIndex = 3;
            // 
            // cinema_email
            // 
            this.cinema_email.Location = new System.Drawing.Point(18, 115);
            this.cinema_email.Margin = new System.Windows.Forms.Padding(2);
            this.cinema_email.Name = "cinema_email";
            this.cinema_email.Size = new System.Drawing.Size(252, 20);
            this.cinema_email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(290, 15);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(302, 173);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // adicionar_sala
            // 
            this.adicionar_sala.Location = new System.Drawing.Point(468, 193);
            this.adicionar_sala.Margin = new System.Windows.Forms.Padding(2);
            this.adicionar_sala.Name = "adicionar_sala";
            this.adicionar_sala.Size = new System.Drawing.Size(123, 38);
            this.adicionar_sala.TabIndex = 7;
            this.adicionar_sala.Text = "Adicionar";
            this.adicionar_sala.UseVisualStyleBackColor = true;
            this.adicionar_sala.Click += new System.EventHandler(this.adicionar_sala_Click);
            // 
            // editar_sala
            // 
            this.editar_sala.Location = new System.Drawing.Point(468, 236);
            this.editar_sala.Margin = new System.Windows.Forms.Padding(2);
            this.editar_sala.Name = "editar_sala";
            this.editar_sala.Size = new System.Drawing.Size(123, 38);
            this.editar_sala.TabIndex = 8;
            this.editar_sala.Text = "Editar";
            this.editar_sala.UseVisualStyleBackColor = true;
            // 
            // eliminar_sala
            // 
            this.eliminar_sala.Location = new System.Drawing.Point(468, 279);
            this.eliminar_sala.Margin = new System.Windows.Forms.Padding(2);
            this.eliminar_sala.Name = "eliminar_sala";
            this.eliminar_sala.Size = new System.Drawing.Size(123, 38);
            this.eliminar_sala.TabIndex = 9;
            this.eliminar_sala.Text = "Eliminar";
            this.eliminar_sala.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nº de Filas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nº de Colunas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nome da Sala";
            // 
            // nomeSala_txt
            // 
            this.nomeSala_txt.Location = new System.Drawing.Point(290, 213);
            this.nomeSala_txt.Margin = new System.Windows.Forms.Padding(2);
            this.nomeSala_txt.Name = "nomeSala_txt";
            this.nomeSala_txt.Size = new System.Drawing.Size(168, 20);
            this.nomeSala_txt.TabIndex = 10;
            // 
            // CBnumeroColunas
            // 
            this.CBnumeroColunas.Location = new System.Drawing.Point(290, 256);
            this.CBnumeroColunas.Margin = new System.Windows.Forms.Padding(2);
            this.CBnumeroColunas.Name = "CBnumeroColunas";
            this.CBnumeroColunas.Size = new System.Drawing.Size(167, 20);
            this.CBnumeroColunas.TabIndex = 16;
            // 
            // CBnumeroFilas
            // 
            this.CBnumeroFilas.Location = new System.Drawing.Point(290, 299);
            this.CBnumeroFilas.Margin = new System.Windows.Forms.Padding(2);
            this.CBnumeroFilas.Name = "CBnumeroFilas";
            this.CBnumeroFilas.Size = new System.Drawing.Size(167, 20);
            this.CBnumeroFilas.TabIndex = 17;
            // 
            // cinema_change
            // 
            this.cinema_change.Location = new System.Drawing.Point(18, 145);
            this.cinema_change.Margin = new System.Windows.Forms.Padding(2);
            this.cinema_change.Name = "cinema_change";
            this.cinema_change.Size = new System.Drawing.Size(250, 42);
            this.cinema_change.TabIndex = 18;
            this.cinema_change.Text = "Atualizar";
            this.cinema_change.UseVisualStyleBackColor = true;
            this.cinema_change.Click += new System.EventHandler(this.cinema_change_Click);
            // 
            // dataGridViewLugares
            // 
            this.dataGridViewLugares.AllowUserToAddRows = false;
            this.dataGridViewLugares.AllowUserToDeleteRows = false;
            this.dataGridViewLugares.AllowUserToResizeColumns = false;
            this.dataGridViewLugares.AllowUserToResizeRows = false;
            this.dataGridViewLugares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLugares.ColumnHeadersVisible = false;
            this.dataGridViewLugares.Location = new System.Drawing.Point(19, 197);
            this.dataGridViewLugares.MultiSelect = false;
            this.dataGridViewLugares.Name = "dataGridViewLugares";
            this.dataGridViewLugares.RowHeadersVisible = false;
            this.dataGridViewLugares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewLugares.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewLugares.TabIndex = 19;
            this.dataGridViewLugares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLugares_CellClick);
            // 
            // FormCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 334);
            this.Controls.Add(this.dataGridViewLugares);
            this.Controls.Add(this.cinema_change);
            this.Controls.Add(this.CBnumeroFilas);
            this.Controls.Add(this.CBnumeroColunas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nomeSala_txt);
            this.Controls.Add(this.eliminar_sala);
            this.Controls.Add(this.editar_sala);
            this.Controls.Add(this.adicionar_sala);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cinema_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cinema_morada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cinema_nome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCinema";
            this.Text = "FormCinema";
            ((System.ComponentModel.ISupportInitialize)(this.CBnumeroColunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBnumeroFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLugares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cinema_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cinema_morada;
        private System.Windows.Forms.TextBox cinema_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button adicionar_sala;
        private System.Windows.Forms.Button editar_sala;
        private System.Windows.Forms.Button eliminar_sala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nomeSala_txt;
        private System.Windows.Forms.NumericUpDown CBnumeroColunas;
        private System.Windows.Forms.NumericUpDown CBnumeroFilas;
        private System.Windows.Forms.Button cinema_change;
        private System.Windows.Forms.DataGridView dataGridViewLugares;
    }
}