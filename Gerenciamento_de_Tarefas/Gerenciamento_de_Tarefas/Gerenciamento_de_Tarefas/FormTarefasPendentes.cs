using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Gerenciamento_de_Tarefas.Program;

namespace Gerenciamento_de_Tarefas
{
    public partial class FormTarefasPendentes : Form
    {
        public FormTarefasPendentes()
        {
            InitializeComponent();
        }

        private void FormTarefasPendentes_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Tarefa Dados in DadosTarefa.Tarefas)
            {
                if (Dados.Status == "Pendente")
                {
                     FlowLayoutPanel ReceberTarefas = new FlowLayoutPanel();
                ReceberTarefas.AutoSize = true;
                ReceberTarefas.FlowDirection = FlowDirection.TopDown;
                Label Informacoes = new Label();
                Informacoes.AutoSize = true;


                Informacoes.Text = $"Nome: {Dados.Nome}\nDescrição: {Dados.Descricao} ";//Template String Você pode pular linha juntando o texto e a variavel
                CheckBox Verificar = new CheckBox();
                Verificar.Text = "Confirmar Tarefa";
                Verificar.Tag = Dados; //Guardar a tarefa atribuida a caixa de texto
                ReceberTarefas.Controls.Add(Informacoes); //adicionando de forma organizada os dados da tarefa
                ReceberTarefas.Controls.Add(Verificar);
                flowLayoutPanel1.Controls.Add(ReceberTarefas);
                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control Design in flowLayoutPanel1.Controls) //Variavel control é todo tipo de elemento visual do desing
            {
                if (Design is FlowLayoutPanel PainelFilho)
                {
                    foreach (Control Caixa in PainelFilho.Controls)
                    {
                        if (Caixa is CheckBox Confirmar && Confirmar.Checked)
                        {
                            if (Confirmar.Tag is Tarefa x)
                            {
                                x.Status = "Concluir";
                            }
                        }
                    }
                }
            }

            flowLayoutPanel1.Controls.Clear();

            foreach (Tarefa Dados in DadosTarefa.Tarefas)
            {
                if (Dados.Status == "Pendente")
                {
                    FlowLayoutPanel ReceberTarefas = new FlowLayoutPanel();
                    ReceberTarefas.AutoSize = true;
                    ReceberTarefas.FlowDirection = FlowDirection.TopDown;
                    Label Informacoes = new Label();
                    Informacoes.AutoSize = true;


                    Informacoes.Text = $"Nome: {Dados.Nome}\nDescrição: {Dados.Descricao} ";//Template String Você pode pular linha juntando o texto e a variavel
                    CheckBox Verificar = new CheckBox();
                    Verificar.Text = "Confirmar Tarefa";
                    Verificar.Tag = Dados; //Guardar a tarefa atribuida a caixa de texto
                    ReceberTarefas.Controls.Add(Informacoes); //adicionando de forma organizada os dados da tarefa
                    ReceberTarefas.Controls.Add(Verificar);
                    flowLayoutPanel1.Controls.Add(ReceberTarefas);
                }

            }
        }
    }
}
