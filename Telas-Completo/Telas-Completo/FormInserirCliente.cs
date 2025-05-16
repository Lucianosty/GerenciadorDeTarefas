using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Telas_Completo.Program;

namespace Telas_Completo
{
    public partial class FormInserirCliente : Form
    {
        public FormInserirCliente()
        {
            InitializeComponent();
        }

        private void Limpar()
        {  // Limpa os campos
            tbNome.Clear();
            tbTel.Clear();
            tbEmail.Clear();
            tbEndereco.Clear();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(tbNome.Text) ||
                string.IsNullOrWhiteSpace(tbTel.Text) ||
                string.IsNullOrWhiteSpace(tbEmail.Text) ||
                string.IsNullOrWhiteSpace(tbEndereco.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de inserir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cria um novo objeto Pessoa com os dados das TextBox
            var novaPessoa = new Pessoa
            {
                Nome = tbNome.Text,
                Telefone = tbTel.Text,
                Email = tbEmail.Text,
                Endereco = tbEndereco.Text
            };

            // Adiciona a nova pessoa à lista de pessoas
            DadosCompartilhados.Pessoas.Add(novaPessoa);

            // Exibição da Mensagem de inclusão
            MessageBox.Show("Cliente inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpar();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            // Fecha o formulário atual
            this.Close();
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
