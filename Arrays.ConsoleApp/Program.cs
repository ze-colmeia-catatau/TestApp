
namespace Arrays.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Exercícios - Arrays e Funções");
            Console.WriteLine("--------------------------------------");

            #region Declaração do array
            int[] sequencia = new int[16];

            sequencia[0] = -5;
            sequencia[1] = 3;
            sequencia[2] = 4;
            sequencia[3] = 5;
            sequencia[4] = 9;
            sequencia[5] = 6;
            sequencia[6] = 10;
            sequencia[7] = -2;
            sequencia[8] = 11;
            sequencia[9] = 1;
            sequencia[10] = 2;
            sequencia[11] = 6;
            sequencia[12] = 7;
            sequencia[13] = 8;
            sequencia[14] = 0;
            sequencia[15] = -6;
            #endregion

            // Mostrar na Tela os valores da sequência
            Console.WriteLine($"\nSequência: [{string.Join(", ", sequencia)}]");

            // Encontrar o Maior Valor da sequência
            int maiorValor = int.MinValue;

            for (int i = 0; i < sequencia.Length; i++)
            {
                if (sequencia[i] > maiorValor)
                {
                    maiorValor = sequencia[i];
                }
            }

            Console.WriteLine("\nMaior valor: " + maiorValor);

            // Encontrar o Menor Valor da sequência
            int menorValor = int.MaxValue;

            for (int i = 0; i < sequencia.Length; i++)
            {
                if (sequencia[i] < menorValor)
                {
                    menorValor = sequencia[i];
                }
            }

            Console.WriteLine("\nMenor valor: " + menorValor);

            // Encontrar o Valor Médio da sequência
            double soma = 0;

            for (int i = 0; i < sequencia.Length; i++)
            {
                soma += sequencia[i];
            }

            double valorMedio = soma / sequencia.Length;

            Console.WriteLine("\nValor médio: " + valorMedio);

            // Encontrar os 3 maiores valores da sequência
            int[] copia = new int[sequencia.Length];

            Array.Copy(sequencia, copia, sequencia.Length);

            Array.Sort(copia);

            Array.Reverse(copia);

            Console.WriteLine("\nOs 3 maiores valores são: " + copia[0] + ", " + copia[1] + ", " + copia[2]);

            // Encontrar os valores negativos da sequência
            int contadorValoresNegativos = 0;

            for (int i = 0; i < sequencia.Length; i++)
            {
                if (sequencia[i] < 0)
                    contadorValoresNegativos++;
            }

                // Inicializa o array de valores negativos com o tamanho exato necessário
            int[] valoresNegativos = new int[contadorValoresNegativos];

            int indiceValoresNegativos = 0; 
            for (int i = 0; i < sequencia.Length; i++)
            {
                if (sequencia[i] < 0)
                {
                    valoresNegativos[indiceValoresNegativos] = sequencia[i];
                    indiceValoresNegativos++;
                }
            }

            Console.WriteLine($"\nValores negativos: [{ string.Join(", ", valoresNegativos) }]");

            // Remover um item da sequência
            int[] novoArray = new int[sequencia.Length - 1];

            int posicaoParaRemover = 0;

            for (int i = 0, j = 0; i < sequencia.Length; i++)
            {
                if (i != posicaoParaRemover)
                {
                    novoArray[j++] = sequencia[i];
                }
            }

            Console.WriteLine($"\nSequência após remoção: [{string.Join(", ", novoArray)}]");

            // fim do progama
            Console.ReadLine();
        }
    }
}
