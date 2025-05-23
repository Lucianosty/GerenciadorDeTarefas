namespace Gerenciamento_de_Tarefas
{
    internal static class Program
    {
        public class Tarefa
        {
            public string Nome { get; set; }
            public string Descricao { get; set; }

            public string Status { get; set; }



        }

            internal static class DadosTarefa
            {
                public static List<Tarefa> Tarefas { get; } = new()
                {
                    new Tarefa
                    {
                        Nome = "Estudar",
                        Descricao = "Estudar 4 horas por dia"
                    }
                };
            };



            /// <summary>
            ///  The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
        
    }
}