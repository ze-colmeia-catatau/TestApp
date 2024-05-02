namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        public int numero;
        public decimal saldo;
        public Cliente titular;

        private Movimentacao[] historicoMovimentacoes = new Movimentacao[100];
        private int qtdMovimentacoes;

        public void Sacar(decimal valor)
        {
            Movimentacao movimentacao = new Movimentacao();
            movimentacao.valor = valor;
            movimentacao.tipoMovimentacao = "Saque";

            RegistrarMovimentacao(movimentacao);

            saldo -= valor;
        }

        public void Depositar(decimal valor)
        {
            Movimentacao movimentacao = new Movimentacao();
            movimentacao.valor = valor;
            movimentacao.tipoMovimentacao = "Depósito";

            RegistrarMovimentacao(movimentacao);

            saldo += valor;
        }

        public void Transferir(decimal valor, ContaCorrente destinatario)
        {
            saldo -= valor;

            destinatario.ReceberTransferencia(valor);

            Movimentacao movimentacao = new Movimentacao();
            movimentacao.valor = valor;
            movimentacao.tipoMovimentacao = "Transferência Enviada";

            RegistrarMovimentacao(movimentacao);
        }

        public void ReceberTransferencia(decimal valor)
        {
            saldo += valor;

            Movimentacao movimentacao = new Movimentacao();
            movimentacao.valor = valor;
            movimentacao.tipoMovimentacao = "Transferência Recebida";

            RegistrarMovimentacao(movimentacao);
        }

        public void RegistrarMovimentacao(Movimentacao movimentacao)
        {
            historicoMovimentacoes[qtdMovimentacoes++] = movimentacao;
        }

        public decimal ObterSaldo()
        {
            return saldo;
        }

        public Movimentacao[] ObterHistórico()
        {
            return historicoMovimentacoes;
        }
    }
}
