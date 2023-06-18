namespace Cinema.View
{
    partial class FormFuncionarios
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Nome = new System.Windows.Forms.Label();
            this.fun_name = new System.Windows.Forms.TextBox();
            this.fun_morada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fun_salario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fun_funcao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.add_fun = new System.Windows.Forms.Button();
            this.del_fun = new System.Windows.Forms.Button();
            this.limp_campos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(269, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 276);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(12, 12);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(47, 16);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome:";
            // 
            // fun_name
            // 
            this.fun_name.Location = new System.Drawing.Point(12, 31);
            this.fun_name.Name = "fun_name";
            this.fun_name.Size = new System.Drawing.Size(228, 22);
            this.fun_name.TabIndex = 2;
            // 
            // fun_morada
            // 
            this.fun_morada.Location = new System.Drawing.Point(12, 89);
            this.fun_morada.Name = "fun_morada";
            this.fun_morada.Size = new System.Drawing.Size(228, 22);
            this.fun_morada.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Morada:";
            // 
            // fun_salario
            // 
            this.fun_salario.Location = new System.Drawing.Point(12, 145);
            this.fun_salario.Name = "fun_salario";
            this.fun_salario.Size = new System.Drawing.Size(228, 22);
            this.fun_salario.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salário:";
            // 
            // fun_funcao
            // 
            this.fun_funcao.Location = new System.Drawing.Point(12, 202);
            this.fun_funcao.Name = "fun_funcao";
            this.fun_funcao.Size = new System.Drawing.Size(228, 22);
            this.fun_funcao.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Função:";
            // 
            // add_fun
            // 
            this.add_fun.Location = new System.Drawing.Point(15, 294);
            this.add_fun.Name = "add_fun";
            this.add_fun.Size = new System.Drawing.Size(479, 46);
            this.add_fun.TabIndex = 9;
            this.add_fun.Text = "Adicionar/Editar Funcionário";
            this.add_fun.UseVisualStyleBackColor = true;
            this.add_fun.Click += new System.EventHandler(this.add_fun_Click);
            // 
            // del_fun
            // 
            this.del_fun.Location = new System.Drawing.Point(12, 346);
            this.del_fun.Name = "del_fun";
            this.del_fun.Size = new System.Drawing.Size(479, 46);
            this.del_fun.TabIndex = 10;
            this.del_fun.Text = "Remover Funcionário";
            this.del_fun.UseVisualStyleBackColor = true;
            this.del_fun.Click += new System.EventHandler(this.del_fun_Click);
            // 
            // limp_campos
            // 
            this.limp_campos.Location = new System.Drawing.Point(15, 241);
            this.limp_campos.Name = "limp_campos";
            this.limp_campos.Size = new System.Drawing.Size(228, 47);
            this.limp_campos.TabIndex = 11;
            this.limp_campos.Text = "Limpar Campos";
            this.limp_campos.UseVisualStyleBackColor = true;
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 405);
            this.Controls.Add(this.limp_campos);
            this.Controls.Add(this.del_fun);
            this.Controls.Add(this.add_fun);
            this.Controls.Add(this.fun_funcao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fun_salario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fun_morada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fun_name);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.listBox1);
            this.Name = "FormFuncionarios";
            this.Text = "Funcionários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox fun_name;
        private System.Windows.Forms.TextBox fun_morada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fun_salario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fun_funcao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_fun;
        private System.Windows.Forms.Button del_fun;
        private System.Windows.Forms.Button limp_campos;
    }
}