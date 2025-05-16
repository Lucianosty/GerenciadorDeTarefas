namespace Telas_Completo
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnRes = new Button();
            label1 = new Label();
            btnMin = new Button();
            btnMax = new Button();
            btnFechar = new Button();
            panel2 = new Panel();
            btnFechar2 = new Button();
            btnPrincipal = new Button();
            btnInserir = new Button();
            btnCliente = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(btnRes);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMin);
            panel1.Controls.Add(btnMax);
            panel1.Controls.Add(btnFechar);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 18F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 40);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnRes
            // 
            btnRes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRes.FlatAppearance.BorderColor = Color.White;
            btnRes.FlatAppearance.BorderSize = 0;
            btnRes.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnRes.FlatAppearance.MouseOverBackColor = Color.Red;
            btnRes.FlatStyle = FlatStyle.Flat;
            btnRes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRes.ForeColor = Color.White;
            btnRes.Location = new Point(714, 0);
            btnRes.Name = "btnRes";
            btnRes.Size = new Size(40, 40);
            btnRes.TabIndex = 3;
            btnRes.Text = "[  ]]";
            btnRes.UseVisualStyleBackColor = true;
            btnRes.Visible = false;
            btnRes.Click += btnRes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(214, 32);
            label1.TabIndex = 2;
            label1.Text = "Sistema de Vendas";
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.FlatAppearance.BorderColor = Color.White;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnMin.FlatAppearance.MouseOverBackColor = Color.Red;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMin.ForeColor = Color.White;
            btnMin.Location = new Point(668, 0);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(40, 40);
            btnMin.TabIndex = 1;
            btnMin.Text = "_";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.FlatAppearance.BorderColor = Color.White;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnMax.FlatAppearance.MouseOverBackColor = Color.Red;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMax.ForeColor = Color.White;
            btnMax.Location = new Point(714, 0);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(40, 40);
            btnMax.TabIndex = 1;
            btnMax.Text = "[  ]";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFechar.FlatAppearance.BorderColor = Color.White;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(760, 0);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(40, 40);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 46, 59);
            panel2.Controls.Add(btnFechar2);
            panel2.Controls.Add(btnPrincipal);
            panel2.Controls.Add(btnInserir);
            panel2.Controls.Add(btnCliente);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 410);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnFechar2
            // 
            btnFechar2.FlatAppearance.BorderColor = Color.White;
            btnFechar2.FlatAppearance.BorderSize = 0;
            btnFechar2.FlatAppearance.MouseDownBackColor = Color.White;
            btnFechar2.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnFechar2.FlatStyle = FlatStyle.Flat;
            btnFechar2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar2.ForeColor = Color.White;
            btnFechar2.Location = new Point(12, 144);
            btnFechar2.Name = "btnFechar2";
            btnFechar2.Size = new Size(170, 40);
            btnFechar2.TabIndex = 3;
            btnFechar2.Text = "Fechar";
            btnFechar2.UseVisualStyleBackColor = true;
            btnFechar2.Click += btnFechar2_Click;
            // 
            // btnPrincipal
            // 
            btnPrincipal.FlatAppearance.BorderColor = Color.White;
            btnPrincipal.FlatAppearance.BorderSize = 0;
            btnPrincipal.FlatAppearance.MouseDownBackColor = Color.White;
            btnPrincipal.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnPrincipal.FlatStyle = FlatStyle.Flat;
            btnPrincipal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrincipal.ForeColor = Color.White;
            btnPrincipal.Location = new Point(12, 6);
            btnPrincipal.Name = "btnPrincipal";
            btnPrincipal.Size = new Size(170, 40);
            btnPrincipal.TabIndex = 2;
            btnPrincipal.Text = "Principal";
            btnPrincipal.UseVisualStyleBackColor = true;
            btnPrincipal.Click += btnPrincipal_Click;
            // 
            // btnInserir
            // 
            btnInserir.FlatAppearance.BorderColor = Color.White;
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatAppearance.MouseDownBackColor = Color.White;
            btnInserir.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserir.ForeColor = Color.White;
            btnInserir.Location = new Point(12, 98);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(170, 40);
            btnInserir.TabIndex = 1;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnCliente
            // 
            btnCliente.FlatAppearance.BorderColor = Color.White;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatAppearance.MouseDownBackColor = Color.White;
            btnCliente.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCliente.ForeColor = Color.White;
            btnCliente.Location = new Point(12, 52);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(170, 40);
            btnCliente.TabIndex = 0;
            btnCliente.Text = "Clientes";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(188, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(612, 410);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Principal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnFechar;
        private Button btnMin;
        private Button btnMax;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button btnCliente;
        private Button btnFechar2;
        private Button btnPrincipal;
        private Button btnInserir;
        private Button btnRes;
    }
}
