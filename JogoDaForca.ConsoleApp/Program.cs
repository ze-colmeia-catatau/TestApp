namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forca forca = new Forca();

            forca.GerarPalavra();
            forca.GerarPalavraMascarada();

            bool jogadorAcertou = false;

            while (jogadorAcertou == false && forca.JogadorPerdeu() == false)
            {
                Console.WriteLine("Jogo da Forca | Academia de Programação!\n");

                geraForca(forca.quantidadeErros);

                Console.WriteLine($"\n\nA palavra escondida é: {string.Join(" ", forca.palavraMascarada)}\n");

                char letraDigitada = obterValor<char>("Digite uma letra: ").ToString().ToUpper()[0];

                jogadorAcertou = forca.PalpiteCorreto(letraDigitada);

                if (jogadorAcertou)
                    Console.WriteLine("Você acertou!");

                else if (forca.JogadorPerdeu())
                    Console.WriteLine("Você perdeu!");
            }
        }

        private static void mostraLetra(string palavraSelecionada, char[] palavraMascarada, ref int tentativas)
        {
            bool acertou;
            bool fimDeJogo = false;

            while (!fimDeJogo)
            {
                Console.WriteLine("Jogo da Forca | Academia de Programação!\n");
                geraForca(tentativas);

                Console.WriteLine($"\n\nA palavra escondida é: {string.Join(" ", palavraMascarada)}\n");
                char letraDigitada = obterValor<char>("Digite uma letra: ").ToString().ToUpper()[0];

                acertou = false;

                for (int i = 0; i < palavraSelecionada.Length; i++)
                {
                    if (letraDigitada == palavraSelecionada[i])
                    {
                        palavraMascarada[i] = letraDigitada;
                        acertou = true;
                    }

                }

                Console.Clear();
                respostaErrada(palavraSelecionada, ref tentativas, acertou, ref fimDeJogo);

            }

        }

        private static void respostaErrada(string palavraSelecionada, ref int tentativas, bool acertou, ref bool fimDeJogo)
        {
            if (!acertou)
            {
                tentativas++;
                if (tentativas >= 5)
                {
                    Console.WriteLine("Você perdeu! :(\n\n\n");
                    Console.WriteLine($"\t\t\tA palavra correta era {palavraSelecionada}\n\n");
                    fimDeJogo = true;
                }
            }
        }

        private static void geradorPalavra(out string palavraSelecionada, out char[] palavraMascarada)
        {
            Random randomizador = new Random();

            string[] palavras = {"ABACATE", "ABACAXI", "ACEROLA", "ACAI", "ARACA", "BACABA", "BACURI",
                        "BANANA", "CAJA", "CAJU", "CARAMBOLA", "CUPUACU", "GRAVIOLA", "GOIABA", "JABUTICABA",
                        "JENIPAPO", "MACA", "MANGABA", "MANGA", "MARACUJA", "MURICI", "PEQUI", "PITANGA",
                        "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA"};

            int indicePalavraSelecionada = randomizador.Next(palavras.Length);

            palavraSelecionada = palavras[indicePalavraSelecionada];

            palavraMascarada = new string('_', palavraSelecionada.Length).ToCharArray();
        }

        static void geraForca(int tentativas)
        {
            switch (tentativas)
            {
                case 0:
                    Console.WriteLine("________\n |\t|\n |\t\n | \n | \n | \n_|___");
                    break;
                case 1:
                    Console.WriteLine("________\n |\t|\n |\tO\n |\t|\n | \n | \n_|___");
                    break;
                case 2:
                    Console.WriteLine("________\n |\t|\n |\tO\n |     /|\n | \n | \n_|___");
                    break;
                case 3:
                    Console.WriteLine("________\n |\t|\n |\tO\n |     /|\\\n | \n | \n_|___");
                    break;
                case 4:
                    Console.WriteLine("________\n |\t|\n |\tO\n |     /|\\\n |     / \n | \n_|___");
                    break;
                case 5:
                    Console.WriteLine("________\n |\t|\n |\tO\n |     /|\\\n |     / \\\n | \n_|___");
                    break;
                default:
                    break;
            }
        }

        static bool jogarNovamente()
        {
            Console.WriteLine("Deseja Continuar? (S / N)");

            string resposta = Console.ReadLine().ToUpper();

            Console.Clear();

            return resposta == "N";

        }

        static T obterValor<T>(string texto)
        {
            Console.WriteLine(texto);
            string input = Console.ReadLine();

            try
            {
                return (T)Convert.ChangeType(input, typeof(T));
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato inválido!");
                return obterValor<T>(texto);
            }
        }
    }
}
