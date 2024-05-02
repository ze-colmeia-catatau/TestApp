namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo();

            triangulo1.LadoX = 10;
            triangulo1.LadoY = 10;
            triangulo1.LadoZ = 10;

            Console.WriteLine(triangulo1.ObterTipo()); // Equilátero

            Triangulo triangulo2 = new Triangulo();

            triangulo2.LadoX = 12;
            triangulo2.LadoY = 10;
            triangulo2.LadoZ = 10;

            Console.WriteLine(triangulo2.ObterTipo()); // Isósceles

            Triangulo triangulo3 = new Triangulo();

            triangulo3.LadoX = 12;
            triangulo3.LadoY = 14;
            triangulo3.LadoZ = 16;

            Console.WriteLine(triangulo3.ObterTipo()); // Escaleno

            Console.ReadLine();
        }
    }

    public class Triangulo
    {
        public int LadoX;
        public int LadoY;
        public int LadoZ;

        public string ObterTipo()
        {
            string tipo = "";

            if (LadoXInvalido() || LadoYInvalido() || LadoZInvalido())
                tipo = "Triângulo Inválido";

            else if (LadoX == LadoY && LadoY == LadoZ)
                tipo = "Equilátero";

            else if (LadoX != LadoY && LadoY != LadoZ && LadoZ != LadoX)
                tipo = "Escaleno";

            else
                tipo = "Isósceles";

            return tipo;
        }

        public bool LadoXInvalido()
        {
            bool ladoXInvalido = LadoX > LadoY + LadoZ;

            return ladoXInvalido;
        }

        public bool LadoYInvalido()
        {
            bool ladoYInvalido = LadoY > LadoX + LadoZ;

            return ladoYInvalido;
        }

        public bool LadoZInvalido()
        {
            bool ladoZInvalido = LadoZ > LadoX + LadoY;

            return ladoZInvalido;
        }
    }
}
