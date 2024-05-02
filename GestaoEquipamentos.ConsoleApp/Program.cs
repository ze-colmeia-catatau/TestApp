namespace GestaoEquipamentos.ConsoleApp
{
    public class Program
    {
        static Equipamento[] equipamentos = new Equipamento[100];
        static int contadorEquipamentos = 0;

        static void Main(string[] args)
        {
            equipamentos[contadorEquipamentos++] = new Equipamento(
                "Notebook",
                "AEX-012",
                "Acer",
                2000.00m,
                Convert.ToDateTime("20/04/2020")
            );

            bool opcaoSairEscolhida = false;

            while (!opcaoSairEscolhida)
            {
                ExibirTituloMenu();

                Console.WriteLine("1 - Gerenciar Equipamentos");
                Console.WriteLine("S - Sair");

                Console.WriteLine();

                Console.Write("Escolha uma opção: ");
                string opcaoEscolhida = Console.ReadLine();

                switch (opcaoEscolhida)
                {
                    case "1": ExibirMenuEquipamentos(); break;

                    default: opcaoSairEscolhida = false; break;
                }
            }

            Console.ReadLine();
        }

        public static void ExibirTituloMenu()
        {
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|        Gestão de Equipamentos        |");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();
        }

        public static void ExibirMenuEquipamentos()
        {
            ExibirTituloMenu();

            Console.WriteLine("1 - Cadastrar Equipamento");
            Console.WriteLine("2 - Editar Equipamento");
            Console.WriteLine("3 - Excluir Equipamento");
            Console.WriteLine("4 - Visualizar Equipamentos Cadastrados");
            Console.WriteLine("S - Voltar");

            Console.Write("\nEscolha uma opção: ");
            string opcaoEscolhida = Console.ReadLine();

            switch (opcaoEscolhida)
            {
                case "1": CadastrarEquipamento(); break;
                case "4": VisualizarEquipamentos(); break;

                default: break;
            }
        }

        public static void CadastrarEquipamento()
        {
            string nome, numeroSerie, fabricante;
            decimal precoAquisicao;
            DateTime dataFabricacao;

            ExibirTituloMenu();

            Console.WriteLine("Cadastrando Equipamento");
            Console.WriteLine();

            Console.Write("Digite o nome ou descritor do equipamento: ");
            nome = Console.ReadLine();

            Console.Write("Digite o número de série do equipamento: ");
            numeroSerie = Console.ReadLine();

            Console.Write("Digite o nome do fabricante do equipamento: ");
            fabricante = Console.ReadLine();

            Console.Write("Digite o preço de aquisição do equipamento: R$ ");
            precoAquisicao = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a data de fabricação do equipamento (formato: dd-MM-aaaa): ");
            dataFabricacao = Convert.ToDateTime(Console.ReadLine());

            Equipamento equipamento = new Equipamento(nome, numeroSerie, fabricante, precoAquisicao, dataFabricacao);

            equipamentos[contadorEquipamentos++] = equipamento;

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine("O equipamento foi cadastrado com sucesso!");
            Console.ReadLine();

            Console.ResetColor();
        }

        public static void VisualizarEquipamentos()
        {
            ExibirTituloMenu();

            Console.WriteLine("Visualizando Equipamentos Cadastrados");
            Console.WriteLine();
            Console.WriteLine(
                "{0, -5} | {1, -15} | {2, -15} | {3, -10} | {4, 10}",
                "Id", "Nome", "Fabricante", "Preço", "Data de Fabricação"
            );

            for (int i = 0; i < contadorEquipamentos; i++)
            {
                Equipamento e = equipamentos[i];

                Console.WriteLine(
                    "{0, -5} | {1, -15} | {2, -15} | {3, -10} | {4, 10}",
                    e.Id, e.Nome, e.Fabricante, e.PrecoAquisicao, e.DataFabricacao.ToShortDateString()
                );
            }

            Console.WriteLine();
            Console.Write("Aperte ENTER para voltar...");
            Console.ReadLine();
        }
    }
}
