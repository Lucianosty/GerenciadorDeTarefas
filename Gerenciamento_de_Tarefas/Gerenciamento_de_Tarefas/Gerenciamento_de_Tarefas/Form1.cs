namespace Gerenciamento_de_Tarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inicio()
        {
            FormComeco inicio = new FormComeco();
            inicio.TopLevel = false;
            inicio.FormBorderStyle = FormBorderStyle.None;
            inicio.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(inicio);
            inicio.Show();
        }

        private void NovaTarefa()
        {
            FormNovaTarefa NovaTarefa = new FormNovaTarefa();
            NovaTarefa.TopLevel = false;
            NovaTarefa.FormBorderStyle = FormBorderStyle.None;
            NovaTarefa.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(NovaTarefa);
            NovaTarefa.Show();
        }

        private void TarefasPendentes()
        {
            FormTarefasPendentes TarefasPendentes = new FormTarefasPendentes();
            TarefasPendentes.TopLevel = false;
            TarefasPendentes.FormBorderStyle = FormBorderStyle.None;
            TarefasPendentes.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(TarefasPendentes);
            TarefasPendentes.Show();
        }

        private void TarefaConcluida()
        {
            TarefasConcluidas TarefaConcluida = new TarefasConcluidas();
            TarefaConcluida.TopLevel = false;
            TarefaConcluida.FormBorderStyle = FormBorderStyle.None;
            TarefaConcluida.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(TarefaConcluida);
            TarefaConcluida.Show();
        }

        private void btnNovaTarefa_Click(object sender, EventArgs e)
        {
            NovaTarefa();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TarefaConcluida();
        }

        private void btnTarefasPen_Click(object sender, EventArgs e)
        {
            TarefasPendentes();
        }
    }
}
