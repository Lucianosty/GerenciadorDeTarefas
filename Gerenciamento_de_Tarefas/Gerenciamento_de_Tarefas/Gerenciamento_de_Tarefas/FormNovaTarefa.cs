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
    public partial class FormNovaTarefa : Form
    {
        public FormNovaTarefa()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            tbNomeTarefa.Clear();
            DescricaoTarefa.Clear();
        }


        private void DescricaoTarefa_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNomeTarefa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNomeTarefa.Text) ||
                string.IsNullOrWhiteSpace(DescricaoTarefa.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de inserir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var NovaTarefa = new Tarefa
            {
                Nome = tbNomeTarefa.Text,
                Descricao = DescricaoTarefa.Text,
                Status = "Pendente"

            };

            DadosTarefa.Tarefas.Add(NovaTarefa);

            MessageBox.Show("Tarefa adicionada com sucesso!", "Sucesso" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        }
    }

