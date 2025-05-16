namespace Telas_Completo
{
    // Layout "inspirado" no exemplo disponibilizado no site do Macoratti
    // https://macoratti.net/18/12/c_imodern1.htm
    internal static class Program
    {
        // Classe para representar os dados de uma pessoa
        public class Pessoa
        {
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }
            public string Endereco { get; set; }
        }

        internal static class DadosCompartilhados
        {
            // Lista para armazenar os dados das pessoas
            public static List<Pessoa> Pessoas { get; } = new()
        {
            new Pessoa
            {
                Nome = "João Silva",
                Telefone = "(11) 98765-4321",
                Email = "joao.silva@email.com",
                Endereco = "Rua das Flores, 123"
            },
            new Pessoa
            {
                Nome = "Maria Oliveira",
                Telefone = "(21) 91234-5678",
                Email = "maria.oliveira@email.com",
                Endereco = "Avenida Central, 456"
            },
            new Pessoa
            {
                Nome = "Carlos Pereira",
                Telefone = "(31) 99876-5432",
                Email = "carlos.pereira@email.com",
                Endereco = "Praça da Liberdade, 789"
            },
            new Pessoa
            {
                Nome = "Ana Costa",
                Telefone = "(41) 98765-1234",
                Email = "ana.costa@email.com",
                Endereco = "Rua do Sol, 321"
            },
            new Pessoa
            {
                Nome = "Pedro Santos",
                Telefone = "(51) 91234-8765",
                Email = "pedro.santos@email.com",
                Endereco = "Avenida das Palmeiras, 654"
            }
        };
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Principal());
        }
    }
}