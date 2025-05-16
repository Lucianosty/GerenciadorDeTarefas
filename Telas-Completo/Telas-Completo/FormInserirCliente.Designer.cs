namespace Telas_Completo
{
    partial class FormInserirCliente
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
            label1 = new Label();
            tbNome = new TextBox();
            label2 = new Label();
            tbTel = new TextBox();
            label3 = new Label();
            tbEmail = new TextBox();
            label4 = new Label();
            tbEndereco = new TextBox();
            btInserir = new Button();
            btLimpar = new Button();
            btFechar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(12, 27);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(292, 23);
            tbNome.TabIndex = 1;
            tbNome.TextChanged += tbNome_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefone";
            // 
            // tbTel
            // 
            tbTel.Location = new Point(12, 71);
            tbTel.Name = "tbTel";
            tbTel.Size = new Size(292, 23);
            tbTel.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "E-mail";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(12, 115);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(292, 23);
            tbEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "Endereço";
            // 
            // tbEndereco
            // 
            tbEndereco.Location = new Point(12, 159);
            tbEndereco.Multiline = true;
            tbEndereco.Name = "tbEndereco";
            tbEndereco.Size = new Size(292, 60);
            tbEndereco.TabIndex = 7;
            // 
            // btInserir
            // 
            btInserir.BackColor = Color.FromArgb(64, 64, 64);
            btInserir.FlatAppearance.BorderColor = Color.White;
            btInserir.FlatAppearance.BorderSize = 0;
            btInserir.FlatAppearance.MouseDownBackColor = Color.White;
            btInserir.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btInserir.FlatStyle = FlatStyle.Flat;
            btInserir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btInserir.ForeColor = Color.White;
            btInserir.Location = new Point(12, 225);
            btInserir.Name = "btInserir";
            btInserir.Size = new Size(85, 35);
            btInserir.TabIndex = 8;
            btInserir.Text = "Inserir";
            btInserir.UseVisualStyleBackColor = false;
            btInserir.Click += btInserir_Click;
            // 
            // btLimpar
            // 
            btLimpar.BackColor = Color.FromArgb(64, 64, 64);
            btLimpar.FlatAppearance.BorderColor = Color.White;
            btLimpar.FlatAppearance.BorderSize = 0;
            btLimpar.FlatAppearance.MouseDownBackColor = Color.White;
            btLimpar.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btLimpar.FlatStyle = FlatStyle.Flat;
            btLimpar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLimpar.ForeColor = Color.White;
            btLimpar.Location = new Point(103, 226);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(85, 35);
            btLimpar.TabIndex = 9;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
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
            btFechar.TabIndex = 10;
            btFechar.Text = "Fechar";
            btFechar.UseVisualStyleBackColor = true;
            btFechar.Click += btFechar_Click;
            // 
            // FormInserirCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 379);
            Controls.Add(btFechar);
            Controls.Add(btLimpar);
            Controls.Add(btInserir);
            Controls.Add(tbEndereco);
            Controls.Add(label4);
            Controls.Add(tbEmail);
            Controls.Add(label3);
            Controls.Add(tbTel);
            Controls.Add(label2);
            Controls.Add(tbNome);
            Controls.Add(label1);
            Name = "FormInserirCliente";
            Text = "FormCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNome;
        private Label label2;
        private TextBox tbTel;
        private Label label3;
        private TextBox tbEmail;
        private Label label4;
        private TextBox tbEndereco;
        private Button btInserir;
        private Button btLimpar;
        private Button btFechar;
    }
}