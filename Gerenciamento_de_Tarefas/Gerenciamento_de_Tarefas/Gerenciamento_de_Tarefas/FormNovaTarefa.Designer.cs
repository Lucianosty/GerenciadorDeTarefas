namespace Gerenciamento_de_Tarefas
{
    partial class FormNovaTarefa
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
            tbNomeTarefa = new TextBox();
            label2 = new Label();
            DescricaoTarefa = new TextBox();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(236, 39);
            label1.Name = "label1";
            label1.Size = new Size(329, 28);
            label1.TabIndex = 0;
            label1.Text = "Digite o nome da sua nova tarefa";
            // 
            // tbNomeTarefa
            // 
            tbNomeTarefa.Location = new Point(241, 75);
            tbNomeTarefa.Name = "tbNomeTarefa";
            tbNomeTarefa.Size = new Size(311, 23);
            tbNomeTarefa.TabIndex = 1;
            tbNomeTarefa.TextChanged += tbNomeTarefa_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(237, 113);
            label2.Name = "label2";
            label2.Size = new Size(196, 28);
            label2.TabIndex = 2;
            label2.Text = "Descrição da tarefa";
            // 
            // DescricaoTarefa
            // 
            DescricaoTarefa.Location = new Point(241, 144);
            DescricaoTarefa.Multiline = true;
            DescricaoTarefa.Name = "DescricaoTarefa";
            DescricaoTarefa.Size = new Size(311, 143);
            DescricaoTarefa.TabIndex = 3;
            DescricaoTarefa.TextChanged += DescricaoTarefa_TextChanged;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.LightSkyBlue;
            btnEnviar.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe UI", 13F);
            btnEnviar.Location = new Point(341, 305);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(101, 37);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Salvar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // FormNovaTarefa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnviar);
            Controls.Add(DescricaoTarefa);
            Controls.Add(label2);
            Controls.Add(tbNomeTarefa);
            Controls.Add(label1);
            Name = "FormNovaTarefa";
            Text = "FormNovaTarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNomeTarefa;
        private Label label2;
        private TextBox DescricaoTarefa;
        private Button btnEnviar;
    }
}