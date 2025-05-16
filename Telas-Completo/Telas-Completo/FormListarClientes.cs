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
    public partial class FormListarClientes : Form
    {
        private int clienteAtualIndex = 0; // Índice do cliente atual


        public FormListarClientes()
        {
            InitializeComponent();
        }

        private void AtualizarCampos()
        {
            // Obtém o cliente atual
            var clienteAtual = DadosCompartilhados.Pessoas[clienteAtualIndex];

            // Preenche os campos com os dados do cliente atual
            tbNome.Text = clienteAtual.Nome;
            tbTel.Text = clienteAtual.Telefone;
            tbEmail.Text = clienteAtual.Email;
            tbEndereco.Text = clienteAtual.Endereco;

            // Atualiza o estado dos botões
            btAnterior.Enabled = clienteAtualIndex > 0;
            btProximo.Enabled = clienteAtualIndex < DadosCompartilhados.Pessoas.Count - 1;
        }

        private void listarTodos()
        {
            // Exibe os dados que você tenha uma TextBox chamada "textBoxClientes"
            textBoxClientes.Multiline = true;                   // Certifique-se de que a propriedade Multiline está habilitada
            textBoxClientes.ScrollBars = ScrollBars.Vertical;   // Adiciona barra de rolagem vertical, se necessário

            // Preenche a TextBox com os nomes e telefones
            textBoxClientes.Text = string.Join(Environment.NewLine,
            DadosCompartilhados.Pessoas.Select(p => $"{p.Nome} - {p.Telefone}"));
        }

        private void FormListarClientes_Load(object sender, EventArgs e)
        {
            listarTodos();
            AtualizarCampos();
        }

        private void btProximo_Click(object sender, EventArgs e)
        {
            // Avança para o próximo cliente, se possível
            if (clienteAtualIndex < DadosCompartilhados.Pessoas.Count - 1)
            {
                clienteAtualIndex++;
                AtualizarCampos();
            }
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            // Volta para o cliente anterior, se possível
            if (clienteAtualIndex > 0)
            {
                clienteAtualIndex--;
                AtualizarCampos();
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual   
        }
    }
}
