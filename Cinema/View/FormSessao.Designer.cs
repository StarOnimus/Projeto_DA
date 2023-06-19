namespace Cinema.View
{
    partial class FormSessao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSessao));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.preco = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.add_sessao = new System.Windows.Forms.Button();
            this.combo_filme = new System.Windows.Forms.ComboBox();
            this.combo_sala = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.del_sess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Preço: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filme: ";
            // 
            // preco
            // 
            this.preco.Location = new System.Drawing.Point(9, 72);
            this.preco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(182, 20);
            this.preco.TabIndex = 7;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(9, 161);
            this.dateTime.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTime.MinDate = new System.DateTime(2023, 6, 17, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(182, 20);
            this.dateTime.TabIndex = 12;
            // 
            // add_sessao
            // 
            this.add_sessao.Location = new System.Drawing.Point(9, 196);
            this.add_sessao.Name = "add_sessao";
            this.add_sessao.Size = new System.Drawing.Size(187, 35);
            this.add_sessao.TabIndex = 13;
            this.add_sessao.Text = "Criar/Editar Sessão";
            this.add_sessao.UseVisualStyleBackColor = true;
            this.add_sessao.Click += new System.EventHandler(this.add_sessao_Click);
            // 
            // combo_filme
            // 
            this.combo_filme.FormattingEnabled = true;
            this.combo_filme.Location = new System.Drawing.Point(11, 35);
            this.combo_filme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combo_filme.Name = "combo_filme";
            this.combo_filme.Size = new System.Drawing.Size(180, 21);
            this.combo_filme.TabIndex = 14;
            // 
            // combo_sala
            // 
            this.combo_sala.FormattingEnabled = true;
            this.combo_sala.Location = new System.Drawing.Point(9, 114);
            this.combo_sala.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.combo_sala.Name = "combo_sala";
            this.combo_sala.Size = new System.Drawing.Size(180, 21);
            this.combo_sala.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sala: ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(201, 35);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 238);
            this.listBox1.TabIndex = 17;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // del_sess
            // 
            this.del_sess.Location = new System.Drawing.Point(9, 238);
            this.del_sess.Name = "del_sess";
            this.del_sess.Size = new System.Drawing.Size(187, 35);
            this.del_sess.TabIndex = 18;
            this.del_sess.Text = "Eliminar Sessão";
            this.del_sess.UseVisualStyleBackColor = true;
            this.del_sess.Click += new System.EventHandler(this.del_sess_Click);
            // 
            // FormSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 289);
            this.Controls.Add(this.del_sess);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.combo_sala);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo_filme);
            this.Controls.Add(this.add_sessao);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.preco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSessao";
            this.Text = "FormSessao";
            this.Load += new System.EventHandler(this.FormSessao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox preco;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Button add_sessao;
        private System.Windows.Forms.ComboBox combo_filme;
        private System.Windows.Forms.ComboBox combo_sala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button del_sess;
    }
}