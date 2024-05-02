namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operações Conta 1
            Cliente cliente1 = new Cliente();

            cliente1.nome = "Tiago Santini";
            cliente1.documento = "022.500.719-90";

            ContaCorrente conta1 = new ContaCorrente();
            conta1.numero = 1;
            conta1.titular = cliente1;
            conta1.saldo = 1000;

            Console.WriteLine($"Conta 1 [{conta1.titular.nome}]");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Saldo: " + conta1.ObterSaldo()); // 1000

            conta1.Sacar(200);

            Console.WriteLine("Saldo após saque [R$200]: " + conta1.ObterSaldo()); // 800

            conta1.Depositar(400);

            Console.WriteLine($"Saldo após depósito [R$400]: {conta1.ObterSaldo()}"); // 1200
            Console.WriteLine();

            // Operações Conta 2
            Cliente cliente2 = new Cliente();

            cliente2.nome = "Alexandre Rech";
            cliente2.documento = "012.210.800-60";

            ContaCorrente conta2 = new ContaCorrente();
            conta2.numero = 2;
            conta2.titular = cliente2;
            conta2.saldo = 3000;

            Console.WriteLine($"Conta 2 [{conta2.titular.nome}]");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Saldo: " + conta2.ObterSaldo()); // 3000

            conta1.Transferir(200, conta2);

            Console.WriteLine("Saldo após receber transferência [R$200]: " + conta2.ObterSaldo()); // 3200
            Console.WriteLine();

            ExibirExtrato(conta1);

            Console.WriteLine();

            ExibirExtrato(conta2);

            Console.ReadLine();
        }

        static void ExibirExtrato(ContaCorrente conta)
        {
            Movimentacao[] movimentacoes = conta.ObterHistórico();

            Console.WriteLine($"Extrato Conta {conta.numero} [{conta.titular.nome}]");
            Console.WriteLine("----------------------------------");

            for (int i = 0; i < movimentacoes.Length; i++)
            {
                Movimentacao movimentacaoAtual = movimentacoes[i];

                if (movimentacaoAtual == null)
                    break;

                Console.WriteLine($"{movimentacaoAtual.valor}\t{movimentacaoAtual.tipoMovimentacao}\t\t");
            }
        }
    }
}
