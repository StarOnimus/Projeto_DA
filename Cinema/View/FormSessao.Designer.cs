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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clienteMorada = new System.Windows.Forms.TextBox();
            this.clienteNome = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.add_sessao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Preço: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filme: ";
            // 
            // clienteMorada
            // 
            this.clienteMorada.Location = new System.Drawing.Point(12, 89);
            this.clienteMorada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clienteMorada.Name = "clienteMorada";
            this.clienteMorada.Size = new System.Drawing.Size(241, 22);
            this.clienteMorada.TabIndex = 7;
            // 
            // clienteNome
            // 
            this.clienteNome.Location = new System.Drawing.Point(15, 36);
            this.clienteNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clienteNome.Name = "clienteNome";
            this.clienteNome.Size = new System.Drawing.Size(239, 22);
            this.clienteNome.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 150);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 6, 17, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // add_sessao
            // 
            this.add_sessao.Location = new System.Drawing.Point(5, 215);
            this.add_sessao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_sessao.Name = "add_sessao";
            this.add_sessao.Size = new System.Drawing.Size(249, 43);
            this.add_sessao.TabIndex = 13;
            this.add_sessao.Text = "Criar Sessão";
            this.add_sessao.UseVisualStyleBackColor = true;
            this.add_sessao.Click += new System.EventHandler(this.add_sessao_Click);
            // 
            // FormSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 305);
            this.Controls.Add(this.add_sessao);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clienteMorada);
            this.Controls.Add(this.clienteNome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox clienteMorada;
        private System.Windows.Forms.TextBox clienteNome;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button add_sessao;
    }
}