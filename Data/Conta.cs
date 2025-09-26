namespace OrusFinancas.Data
{
    // Representa contas bancárias ou carteiras (ex: conta corrente, poupança, investimento).
    public class Conta
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty; // Ex: "Banco do Brasil", "Carteira"
        public decimal SaldoAtual { get; set; }
        
        // Relacionamento 1:N com Usuario (propriedade de navegação)
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        // Relacionamento 1:N com Transacao
        public ICollection<Transacao> Transacoes { get; set; } = new List<Transacao>();
    }
}
