namespace Telas_Completo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRes.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRes.Visible = false;
            btnMax.Visible = true;
        }
        private void listarClientes()
        {
            FormListarClientes lcliente = new FormListarClientes();        // Cria a instância do objeto cliente como um objeto da classe Form FormCliente
            lcliente.TopLevel = false;                       // Define que o objeto do Form atualizar não é um formulário de nível superior
            lcliente.FormBorderStyle = FormBorderStyle.None; // Remove a borda do objeto do Form atualizar
            lcliente.Dock = DockStyle.Fill;                  // Faz com que o objeto do Form atualizar preencha todo o painel
            panel3.Controls.Clear();                        // Apaga todos os elemento anteriores do painel 3 para poder exibir os novos 
            panel3.Controls.Add(lcliente);                   // Adiciona o objeto do Form atualizar ao painel 3
            lcliente.Show();                                 // Exibe o conteúdo do objeto do Form atualizar
        }
        private void inserirCliente()
        {
            FormInserirCliente icliente = new FormInserirCliente();        // Cria a instância do objeto cliente como um objeto da classe Form FormCliente
            icliente.TopLevel = false;                       // Define que o objeto do Form atualizar não é um formulário de nível superior
            icliente.FormBorderStyle = FormBorderStyle.None; // Remove a borda do objeto do Form atualizar
            icliente.Dock = DockStyle.Fill;                  // Faz com que o objeto do Form atualizar preencha todo o painel
            panel3.Controls.Clear();                        // Apaga todos os elemento anteriores do painel 3 para poder exibir os novos 
            panel3.Controls.Add(icliente);                   // Adiciona o objeto do Form atualizar ao painel 3
            icliente.Show();                                 // Exibe o conteúdo do objeto do Form atualizar
        }

        private void inicial()
        {
            FormTelaInicial inicio = new FormTelaInicial();        // Cria a instância do objeto cliente como um objeto da classe Form FormCliente
            inicio.TopLevel = false;                       // Define que o objeto do Form atualizar não é um formulário de nível superior
            inicio.FormBorderStyle = FormBorderStyle.None; // Remove a borda do objeto do Form atualizar
            inicio.Dock = DockStyle.Fill;                  // Faz com que o objeto do Form atualizar preencha todo o painel
            panel3.Controls.Clear();                        // Apaga todos os elemento anteriores do painel 3 para poder exibir os novos 
            panel3.Controls.Add(inicio);                   // Adiciona o objeto do Form atualizar ao painel 3
            inicio.Show();                                 // Exibe o conteúdo do objeto do Form atualizar
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            inicial();
        }
        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            inicial();
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            listarClientes();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            inserirCliente();
        }

        private void btnFechar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
