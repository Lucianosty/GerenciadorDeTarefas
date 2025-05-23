namespace Gerenciamento_de_Tarefas
{
    partial class Form1
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
            btnNovaTarefa = new Button();
            btnTarefasPen = new Button();
            button1 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnNovaTarefa
            // 
            btnNovaTarefa.Anchor = AnchorStyles.Top;
            btnNovaTarefa.BackColor = Color.LightSkyBlue;
            btnNovaTarefa.FlatAppearance.BorderSize = 0;
            btnNovaTarefa.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnNovaTarefa.FlatStyle = FlatStyle.Flat;
            btnNovaTarefa.Font = new Font("Segoe UI", 15F);
            btnNovaTarefa.Location = new Point(194, 23);
            btnNovaTarefa.Name = "btnNovaTarefa";
            btnNovaTarefa.Size = new Size(133, 42);
            btnNovaTarefa.TabIndex = 0;
            btnNovaTarefa.Text = "Nova Tarefa";
            btnNovaTarefa.UseVisualStyleBackColor = false;
            btnNovaTarefa.Click += btnNovaTarefa_Click;
            // 
            // btnTarefasPen
            // 
            btnTarefasPen.Anchor = AnchorStyles.Top;
            btnTarefasPen.BackColor = Color.LightSkyBlue;
            btnTarefasPen.FlatAppearance.BorderSize = 0;
            btnTarefasPen.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnTarefasPen.FlatStyle = FlatStyle.Flat;
            btnTarefasPen.Font = new Font("Segoe UI", 15F);
            btnTarefasPen.Location = new Point(333, 23);
            btnTarefasPen.Name = "btnTarefasPen";
            btnTarefasPen.Size = new Size(173, 42);
            btnTarefasPen.TabIndex = 1;
            btnTarefasPen.Text = "Tarefas Pendentes";
            btnTarefasPen.UseVisualStyleBackColor = false;
            btnTarefasPen.Click += btnTarefasPen_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.LightSkyBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Yellow;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(512, 23);
            button1.Name = "button1";
            button1.Size = new Size(204, 42);
            button1.TabIndex = 2;
            button1.Text = "Tarefas Concluídas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnTarefasPen);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnNovaTarefa);
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 77);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.LightSkyBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Yellow;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(109, 23);
            button2.Name = "button2";
            button2.Size = new Size(79, 42);
            button2.TabIndex = 6;
            button2.Text = "Início";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Segoe UI", 23F);
            label1.Location = new Point(-5, 0);
            label1.Name = "label1";
            label1.Size = new Size(801, 41);
            label1.TabIndex = 5;
            label1.Text = "Gerenciamento de Tarefas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(1, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 420);
            panel1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 536);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnNovaTarefa;
        private Button btnTarefasPen;
        private Button button1;
        private Panel panel2;
        private Label label1;
        private Button button2;
        private Panel panel1;
    }
}
