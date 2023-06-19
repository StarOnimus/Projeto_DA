namespace Cinema
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.cliente = new System.Windows.Forms.Button();
            this.funcionarios = new System.Windows.Forms.Button();
            this.cinema = new System.Windows.Forms.Button();
            this.Sessao = new System.Windows.Forms.Button();
            this.add_filme = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_funci = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cliente
            // 
            this.cliente.Location = new System.Drawing.Point(608, 136);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(133, 57);
            this.cliente.TabIndex = 0;
            this.cliente.Text = "Clientes";
            this.cliente.UseVisualStyleBackColor = true;
            this.cliente.Click += new System.EventHandler(this.cliente_Click);
            // 
            // funcionarios
            // 
            this.funcionarios.Location = new System.Drawing.Point(608, 73);
            this.funcionarios.Name = "funcionarios";
            this.funcionarios.Size = new System.Drawing.Size(133, 57);
            this.funcionarios.TabIndex = 1;
            this.funcionarios.Text = "Funcionários";
            this.funcionarios.UseVisualStyleBackColor = true;
            this.funcionarios.Click += new System.EventHandler(this.funcionarios_Click);
            // 
            // cinema
            // 
            this.cinema.Location = new System.Drawing.Point(608, 10);
            this.cinema.Name = "cinema";
            this.cinema.Size = new System.Drawing.Size(133, 57);
            this.cinema.TabIndex = 2;
            this.cinema.Text = "Cinema";
            this.cinema.UseVisualStyleBackColor = true;
            this.cinema.Click += new System.EventHandler(this.cinema_Click);
            // 
            // Sessao
            // 
            this.Sessao.Location = new System.Drawing.Point(608, 199);
            this.Sessao.Name = "Sessao";
            this.Sessao.Size = new System.Drawing.Size(133, 57);
            this.Sessao.TabIndex = 3;
            this.Sessao.Text = "Sessão";
            this.Sessao.UseVisualStyleBackColor = true;
            this.Sessao.Click += new System.EventHandler(this.Sessao_Click);
            // 
            // add_filme
            // 
            this.add_filme.Location = new System.Drawing.Point(608, 262);
            this.add_filme.Name = "add_filme";
            this.add_filme.Size = new System.Drawing.Size(133, 57);
            this.add_filme.TabIndex = 4;
            this.add_filme.Text = "Filmes";
            this.add_filme.UseVisualStyleBackColor = true;
            this.add_filme.Click += new System.EventHandler(this.add_filme_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(421, 225);
            this.listBox1.TabIndex = 5;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecione com duplo clique uma sessão.";
            // 
            // combo_funci
            // 
            this.combo_funci.FormattingEnabled = true;
            this.combo_funci.Location = new System.Drawing.Point(18, 298);
            this.combo_funci.Name = "combo_funci";
            this.combo_funci.Size = new System.Drawing.Size(421, 21);
            this.combo_funci.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Em utilização por:";
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(762, 337);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_funci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.add_filme);
            this.Controls.Add(this.Sessao);
            this.Controls.Add(this.cinema);
            this.Controls.Add(this.funcionarios);
            this.Controls.Add(this.cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "CineGest";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clientes;
        private System.Windows.Forms.Button cliente;
        private System.Windows.Forms.Button funcionarios;
        private System.Windows.Forms.Button cinema;
        private System.Windows.Forms.Button Sessao;
        private System.Windows.Forms.Button add_filme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.ComboBox combo_funci;
    }
}

