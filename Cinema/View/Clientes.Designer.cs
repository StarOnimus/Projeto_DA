namespace Cinema
{
    partial class Clientes
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
            this.clienteNome = new System.Windows.Forms.TextBox();
            this.clienteMorada = new System.Windows.Forms.TextBox();
            this.clienteNumFisc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adicionar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // clienteNome
            // 
            this.clienteNome.Location = new System.Drawing.Point(142, 19);
            this.clienteNome.Name = "clienteNome";
            this.clienteNome.Size = new System.Drawing.Size(165, 22);
            this.clienteNome.TabIndex = 0;
            // 
            // clienteMorada
            // 
            this.clienteMorada.Location = new System.Drawing.Point(142, 46);
            this.clienteMorada.Name = "clienteMorada";
            this.clienteMorada.Size = new System.Drawing.Size(165, 22);
            this.clienteMorada.TabIndex = 1;
            // 
            // clienteNumFisc
            // 
            this.clienteNumFisc.Location = new System.Drawing.Point(142, 73);
            this.clienteNumFisc.Name = "clienteNumFisc";
            this.clienteNumFisc.Size = new System.Drawing.Size(165, 22);
            this.clienteNumFisc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Morada: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número Fiscal: ";
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(12, 110);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(292, 23);
            this.adicionar.TabIndex = 6;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(340, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 116);
            this.listBox1.TabIndex = 7;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 154);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clienteNumFisc);
            this.Controls.Add(this.clienteMorada);
            this.Controls.Add(this.clienteNome);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clienteNome;
        private System.Windows.Forms.TextBox clienteMorada;
        private System.Windows.Forms.TextBox clienteNumFisc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.ListBox listBox1;
    }
}