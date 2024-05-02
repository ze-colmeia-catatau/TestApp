namespace Adivinhacao.ConsoleApp
{
    internal class Program
    {
        #region Requisito 1 - OK
        /*
            O computador pensará em um número, e você, jogador, precisará adivinhá-lo.
            A cada erro, a máquina lhe dirá se o número chutado foi
            maior ou menor do que o pensado.
            No acerto, deverá parabenizar o jogador.
        */
        #endregion

        #region Requisito 2 - OK
        /*
            Você também poderá escolher o nível de dificuldade do jogo, 
            e isso lhe dará mais ou menos oportunidades de chutar um número.
        */
        #endregion

        #region Requisito 3 - OK
        /*
            Ao final, se você ganhar, o computador lhe dirá quantos pontos você fez,
            baseando-se em quão bons eram seus chutes.
        */
        #endregion

        static double totalDePontos = 1000;

        static void Main(string[] args)
        {
            int nivelDificuldade = 1, totalDeTentativas = 0;

            // Menu Principal
            ApresentarTitulo();

            // Escolha de dificuldade
            nivelDificuldade = SelecionarDificuldade();
            totalDeTentativas = ObterTotalDeTentivas(nivelDificuldade, totalDeTentativas);

            // Gerando o número aleatório
            int numeroSecreto = ObterNumeroSecreto();

            // Jogo Principal
            for (int quantidadeChutes = 1; quantidadeChutes <= totalDeTentativas; quantidadeChutes++)
            {
                Console.Clear();

                ApresentarTitulo();

                Console.WriteLine($"\nTentativa {quantidadeChutes} de {totalDeTentativas}");

                ExibirPontuacao(totalDePontos);

                // Input do usuário
                Console.Write("\nQual o seu chute? ");
                string chute = Console.ReadLine();

                bool jogadorAcertou = Adivinhar(numeroSecreto, chute);

                if (jogadorAcertou)
                    break;

                if (quantidadeChutes == totalDeTentativas)
                    Console.WriteLine("\nVocê não conseguiu encontrar o número, que azar! Tente novamente!");

                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static bool Adivinhar(int numeroSecreto, string chute)
        {
            int numeroChute = Convert.ToInt32(chute);

            bool acertou = numeroChute == numeroSecreto;
            bool menor = numeroChute < numeroSecreto;

            if (acertou)
            {
                Console.WriteLine("\nParabéns, você acertou!");
                return true;
            }
            else if (menor)
                Console.WriteLine("\nSeu chute foi menor que o número secreto");
            else
                Console.WriteLine("\nSeu chute foi maior que o número secreto");

            double pontosPerdidos = Math.Abs((numeroChute - numeroSecreto) / 2);

            totalDePontos = totalDePontos - pontosPerdidos;

            return false;
        }

        private static int ObterNumeroSecreto()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 21);
            return numeroSecreto;
        }

        private static int ObterTotalDeTentivas(int nivelDificuldade, int totalDeTentativas)
        {
            switch (nivelDificuldade)
            {
                case 1:
                    totalDeTentativas = 15;
                    break;
                case 2:
                    totalDeTentativas = 10;
                    break;
                case 3:
                    totalDeTentativas = 5;
                    break;
            }

            return totalDeTentativas;
        }

        private static void ApresentarTitulo()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("* Jogo da Adivinhação *");
            Console.WriteLine("***********************");
        }

        private static int SelecionarDificuldade()
        {
            int nivelDificuldade;

            Console.WriteLine("\nEscolha o nível de dificuldade: ");
            Console.WriteLine("(1) Fácil (2) Médio (3) Difícil");
            Console.Write("\nEscolha: ");

            nivelDificuldade = Convert.ToInt32(Console.ReadLine());
            return nivelDificuldade;
        }

        static void ExibirPontuacao(double pontuacao)
        {
            Console.WriteLine($"{pontuacao} pontos");
        }
    }
}