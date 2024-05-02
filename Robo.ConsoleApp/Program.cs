namespace Robo.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int robosEnviados = 2;

            string[] coordenadas = new string[robosEnviados];
            string[] ordens = new string[robosEnviados];

            #region Preenchendo ordens do(s) robô(s)
            string[] tamanhoPlano = Console.ReadLine().Split(' ');

            for (int robo = 0; robo < robosEnviados; robo++)
            {
                coordenadas[robo] = Console.ReadLine();
                ordens[robo] = Console.ReadLine();
            }
            #endregion

            Console.Clear();

            #region Executando as ordens
            for (int robo = 0; robo < robosEnviados; robo++)
            {
                string[] coordenadasIniciais = coordenadas[robo].Split(' ');

                int posicaoX = Convert.ToInt32(coordenadasIniciais[0]);
                int posicaoY = Convert.ToInt32(coordenadasIniciais[1]);
                char direcao = Convert.ToChar(coordenadasIniciais[2]);

                string ordem = ordens[robo];

                for (int i = 0; i < ordem.Length; i++)
                {
                    char ordemAtual = ordem[i];

                    if (ordemAtual == 'E')
                        direcao = VirarEsquerda(direcao);

                    else if (ordemAtual == 'D')
                        direcao = VirarDireita(direcao);

                    else if (ordemAtual == 'M')
                        MoverRobo(ref posicaoX, ref posicaoY, direcao);
                }

                Console.WriteLine($"{posicaoX} {posicaoY} {direcao}");
            }
            #endregion

            Console.ReadLine();
        }

        private static void MoverRobo(ref int posicaoX, ref int posicaoY, char direcao)
        {
            if (direcao == 'N')
                posicaoY++;

            else if (direcao == 'S')
                posicaoY--;

            else if (direcao == 'L')
                posicaoX++;

            else if (direcao == 'O')
                posicaoX--;
        }

        private static char VirarDireita(char direcao)
        {
            if (direcao == 'N')
                direcao = 'L';

            else if (direcao == 'L')
                direcao = 'S';

            else if (direcao == 'S')
                direcao = 'O';

            else if (direcao == 'O')
                direcao = 'N';
            return direcao;
        }

        private static char VirarEsquerda(char direcao)
        {
            if (direcao == 'N')
                direcao = 'O';

            else if (direcao == 'O')
                direcao = 'S';

            else if (direcao == 'S')
                direcao = 'L';

            else if (direcao == 'L')
                direcao = 'N';
            return direcao;
        }
    }
}