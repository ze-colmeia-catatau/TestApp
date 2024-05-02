namespace JogoDaForca.ConsoleApp
{
    public class Forca
    {
        public string palavraSelecionada;
        
        public char[] palavraMascarada;

        public int quantidadeErros;

        public bool PalpiteCorreto(char letraDigitada)
        {
            bool letraFoiEncontrada = false;

            for (int i = 0; i < palavraSelecionada.Length; i++)
            {
                if (letraDigitada == palavraSelecionada[i])
                {
                    palavraMascarada[i] = letraDigitada;
                    letraFoiEncontrada = true;
                }
            }

            if (letraFoiEncontrada == false)
                quantidadeErros++;

            bool jogadorAcertou = string.Join("", palavraMascarada) == palavraSelecionada;

            return jogadorAcertou;
        }

        public bool JogadorPerdeu()
        {
            return quantidadeErros >= 5;
        }

        public void GerarPalavra()
        {
            Random randomizador = new Random();

            string[] palavras = {"ABACATE", "ABACAXI", "ACEROLA", "ACAI", "ARACA", "BACABA", "BACURI",
                        "BANANA", "CAJA", "CAJU", "CARAMBOLA", "CUPUACU", "GRAVIOLA", "GOIABA", "JABUTICABA",
                        "JENIPAPO", "MACA", "MANGABA", "MANGA", "MARACUJA", "MURICI", "PEQUI", "PITANGA",
                        "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA"};

            int indicePalavraSelecionada = randomizador.Next(palavras.Length);

            palavraSelecionada = palavras[indicePalavraSelecionada];
        }

        public void GerarPalavraMascarada()
        {
            palavraMascarada = new string('_', palavraSelecionada.Length).ToCharArray();
        }
    }
}
