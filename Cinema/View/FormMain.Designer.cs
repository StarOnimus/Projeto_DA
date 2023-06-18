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
            this.cliente = new System.Windows.Forms.Button();
            this.funcionarios = new System.Windows.Forms.Button();
            this.cinema = new System.Windows.Forms.Button();
            this.Sessao = new System.Windows.Forms.Button();
            this.add_filme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cliente
            // 
            this.cliente.Location = new System.Drawing.Point(698, 138);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(133, 57);
            this.cliente.TabIndex = 0;
            this.cliente.Text = "Clientes";
            this.cliente.UseVisualStyleBackColor = true;
            this.cliente.Click += new System.EventHandler(this.cliente_Click);
            // 
            // funcionarios
            // 
            this.funcionarios.Location = new System.Drawing.Point(698, 75);
            this.funcionarios.Name = "funcionarios";
            this.funcionarios.Size = new System.Drawing.Size(133, 57);
            this.funcionarios.TabIndex = 1;
            this.funcionarios.Text = "Funcionários";
            this.funcionarios.UseVisualStyleBackColor = true;
            this.funcionarios.Click += new System.EventHandler(this.funcionarios_Click);
            // 
            // cinema
            // 
            this.cinema.Location = new System.Drawing.Point(698, 12);
            this.cinema.Name = "cinema";
            this.cinema.Size = new System.Drawing.Size(133, 57);
            this.cinema.TabIndex = 2;
            this.cinema.Text = "Cinema";
            this.cinema.UseVisualStyleBackColor = true;
            this.cinema.Click += new System.EventHandler(this.cinema_Click);
            // 
            // Sessao
            // 
            this.Sessao.Location = new System.Drawing.Point(698, 201);
            this.Sessao.Name = "Sessao";
            this.Sessao.Size = new System.Drawing.Size(133, 57);
            this.Sessao.TabIndex = 3;
            this.Sessao.Text = "Sessão";
            this.Sessao.UseVisualStyleBackColor = true;
            this.Sessao.Click += new System.EventHandler(this.Sessao_Click);
            // 
            // add_filme
            // 
            this.add_filme.Location = new System.Drawing.Point(698, 264);
            this.add_filme.Name = "add_filme";
            this.add_filme.Size = new System.Drawing.Size(133, 57);
            this.add_filme.TabIndex = 4;
            this.add_filme.Text = "Filmes";
            this.add_filme.UseVisualStyleBackColor = true;
            this.add_filme.Click += new System.EventHandler(this.add_filme_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(843, 371);
            this.Controls.Add(this.add_filme);
            this.Controls.Add(this.Sessao);
            this.Controls.Add(this.cinema);
            this.Controls.Add(this.funcionarios);
            this.Controls.Add(this.cliente);
            this.Name = "FormMain";
            this.ResumeLayout(false);

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
    }
}

