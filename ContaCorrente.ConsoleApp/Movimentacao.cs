namespace ContaCorrente.ConsoleApp
{
    public class Movimentacao
    {
        public decimal valor;
        public string tipoMovimentacao;

        public string ObterDetalhes()
        {
            return $"Valor: R$ {valor}\tTipo de Movimentação: {tipoMovimentacao}";
        }
    }
}
