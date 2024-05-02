namespace TestApp.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Calculadora Top 2024");

                Console.WriteLine("Digite 1 para Adicionar");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");

                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                if (operacao == "S" || operacao == "s")
                {
                    break;
                }

                Console.WriteLine();

                Console.WriteLine("Digite o primeiro número:");

                int primeiroNumero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");

                int segundoNumero = Convert.ToInt32(Console.ReadLine());

                int resultado = 0;

                if (operacao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }

                else if (operacao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }

                else if (operacao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }

                else if (operacao == "4")
                {
                    while (segundoNumero == 0)
                    {
                        Console.WriteLine("Segundo número não pode ser ZERO, tente novamente");

                        Console.ReadLine();

                        Console.Write("Digite o segundo número: ");

                        segundoNumero = Convert.ToInt32(Console.ReadLine());
                    }
                    resultado = primeiroNumero / segundoNumero;
                }

                Console.WriteLine("O resultado da operação é: " + resultado);

                Console.ReadLine();
            }
            
        }
    }
}
