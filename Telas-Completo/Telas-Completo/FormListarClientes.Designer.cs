namespace Telas_Completo
{
    partial class FormListarClientes
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
            panel1 = new Panel();
            textBoxClientes = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btFechar = new Button();
            btProximo = new Button();
            btAnterior = new Button();
            tbEndereco = new TextBox();
            label4 = new Label();
            tbEmail = new TextBox();
            label3 = new Label();
            tbTel = new TextBox();
            label2 = new Label();
            tbNome = new TextBox();
            label5 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxClientes);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(317, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 534);
            panel1.TabIndex = 0;
            // 
            // textBoxClientes
            // 
            textBoxClientes.Location = new Point(12, 27);
            textBoxClientes.Multiline = true;
            textBoxClientes.Name = "textBoxClientes";
            textBoxClientes.Size = new Size(291, 239);
            textBoxClientes.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 0;
            label1.Text = "Clientes já cadastrados:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btFechar);
            panel2.Controls.Add(btProximo);
            panel2.Controls.Add(btAnterior);
            panel2.Controls.Add(tbEndereco);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(tbEmail);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tbTel);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tbNome);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(315, 534);
            panel2.TabIndex = 1;
            // 
            // btFechar
            // 
            btFechar.BackColor = Color.FromArgb(64, 64, 64);
            btFechar.FlatAppearance.BorderColor = Color.White;
            btFechar.FlatAppearance.BorderSize = 0;
            btFechar.FlatAppearance.MouseDownBackColor = Color.White;
            btFechar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btFechar.FlatStyle = FlatStyle.Flat;
            btFechar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btFechar.ForeColor = Color.White;
            btFechar.Location = new Point(194, 226);
            btFechar.Name = "btFechar";
            btFechar.Size = new Size(85, 35);
            btFechar.TabIndex = 21;
            btFechar.Text = "Fechar";
            btFechar.UseVisualStyleBackColor = true;
            btFechar.Click += btFechar_Click;
            // 
            // btProximo
            // 
            btProximo.BackColor = Color.FromArgb(64, 64, 64);
            btProximo.FlatAppearance.BorderColor = Color.White;
            btProximo.FlatAppearance.BorderSize = 0;
            btProximo.FlatAppearance.MouseDownBackColor = Color.White;
            btProximo.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btProximo.FlatStyle = FlatStyle.Flat;
            btProximo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btProximo.ForeColor = Color.White;
            btProximo.Location = new Point(103, 226);
            btProximo.Name = "btProximo";
            btProximo.Size = new Size(85, 35);
            btProximo.TabIndex = 20;
            btProximo.Text = "Próximo ->";
            btProximo.UseVisualStyleBackColor = true;
            btProximo.Click += btProximo_Click;
            // 
            // btAnterior
            // 
            btAnterior.BackColor = Color.FromArgb(64, 64, 64);
            btAnterior.FlatAppearance.BorderColor = Color.White;
            btAnterior.FlatAppearance.BorderSize = 0;
            btAnterior.FlatAppearance.MouseDownBackColor = Color.White;
            btAnterior.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btAnterior.FlatStyle = FlatStyle.Flat;
            btAnterior.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAnterior.ForeColor = Color.White;
            btAnterior.Location = new Point(12, 225);
            btAnterior.Name = "btAnterior";
            btAnterior.Size = new Size(85, 35);
            btAnterior.TabIndex = 19;
            btAnterior.Text = "<- Anterior";
            btAnterior.UseVisualStyleBackColor = false;
            btAnterior.Click += btAnterior_Click;
            // 
            // tbEndereco
            // 
            tbEndereco.Location = new Point(12, 159);
            tbEndereco.Multiline = true;
            tbEndereco.Name = "tbEndereco";
            tbEndereco.Size = new Size(292, 60);
            tbEndereco.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 17;
            label4.Text = "Endereço";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(12, 115);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(292, 23);
            tbEmail.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 15;
            label3.Text = "E-mail";
            // 
            // tbTel
            // 
            tbTel.Location = new Point(12, 71);
            tbTel.Name = "tbTel";
            tbTel.Size = new Size(292, 23);
            tbTel.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 13;
            label2.Text = "Telefone";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(12, 27);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(292, 23);
            tbNome.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 11;
            label5.Text = "Nome";
            // 
            // FormListarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 534);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormListarClientes";
            Text = "FormListarClientes";
            Load += FormListarClientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBoxClientes;
        private Panel panel2;
        private Button btFechar;
        private Button btProximo;
        private Button btAnterior;
        private TextBox tbEndereco;
        private Label label4;
        private TextBox tbEmail;
        private Label label3;
        private TextBox tbTel;
        private Label label2;
        private TextBox tbNome;
        private Label label5;
        private SaveFileDialog saveFileDialog1;
    }
}