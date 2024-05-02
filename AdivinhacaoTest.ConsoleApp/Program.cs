namespace jogoadivinhacao
{
    internal class Program
    {
        static int pontuacao = 1000;

        static void Main(string[] args)
        {
            int diff, chances = 0;

            int numeroJogador;
            Random r = new Random();
            int numeroAleatorio = r.Next(0, 21);

            Console.WriteLine(numeroAleatorio);
            Console.WriteLine("==============================================");
            Console.WriteLine("             Jogo da Adivinhacao");
            Console.WriteLine("==============================================\n");
            Console.WriteLine("        Escolha o nivel de dificuldade");
            Console.WriteLine("(1) Facil         (2) Medio        (3) Dificil");
            Console.WriteLine("==============================================\n");
            Console.WriteLine("Como jogar:");
            Console.WriteLine("Digite um numero de 1 a 20, afim de descobrir");
            Console.WriteLine("qual surpresa a maquina preparou para voce!");
            Console.WriteLine("==============================================");

            diff = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (diff == 1)
            {
                Console.WriteLine("Boa Sorte!\n");
                chances = 15;
            }

            else if (diff == 2)
            {
                Console.WriteLine("Boa Sorte!\n");
                chances = 10;
            }

            else if (diff == 3)
            {
                Console.WriteLine("Boa Sorte!\n");
                chances = 5;

            }
            else
            {
                Console.WriteLine("Por favor, escolha uma das dificuldades predeterminadas!");
                Console.WriteLine("Pressione qualquer tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
                Main(args);
            }

            for (int i = 1; i <= chances; i++)
            {
                Console.WriteLine("Tentativa " + i + " de " + chances + "\n");
                Console.WriteLine("==============================================");

                Console.WriteLine("Informe o numero desejado: ");

                numeroJogador = Convert.ToInt32(Console.ReadLine());
                if (numeroJogador == numeroAleatorio && numeroJogador < 21 && numeroJogador > 0)
                {

                    Console.Clear();
                    pontuacao -= Math.Abs((numeroJogador - numeroAleatorio) / 2);
                    Console.WriteLine("Parabens, voce adivinhou o numero secreto!");
                    Console.WriteLine("Pontuacao final: " + pontuacao);
                    Console.WriteLine("Pressione qualquer tecla para fechar o aplicativo!");
                    Console.ReadKey();
                    break;
                }
                else if (numeroJogador < numeroAleatorio && numeroJogador < 21 && numeroJogador > 0)
                {

                    Console.Clear();
                    pontuacao -= Math.Abs((numeroJogador - numeroAleatorio) / 2);
                    Console.WriteLine("Muito baixo, tente novamente!");
                    Console.WriteLine("Pontuacao atual: " + pontuacao);
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }


                else if (numeroJogador > numeroAleatorio && numeroJogador < 21 && numeroJogador > 0)
                {
                    Console.Clear();
                    pontuacao -= Math.Abs((numeroJogador - numeroAleatorio) / 2);
                    Console.WriteLine("Muito alto, tente novamente !");
                    Console.WriteLine("Pontuacao atual: " + pontuacao);
                    Console.WriteLine("Pressione qualquer teclapara continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Fora de Alcance, tente novamente!");
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (numeroJogador != numeroAleatorio)
                {
                    pontuacao += Math.Abs((numeroJogador - numeroAleatorio) / 2);
                }
            }

        }
    }
}