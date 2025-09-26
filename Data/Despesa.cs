namespace OrusFinancas.Data
{
    // Representa uma saída de dinheiro.
    public class Despesa : Transacao
    {
        public string Local { get; set; } = string.Empty; // Ex: "Supermercado X", "Amazon"
        public bool Reembolsavel { get; set; }

        // Relacionamento 1:N com Assinatura (A Assinatura gera Despesas)
        public int? AssinaturaId { get; set; } // Nullable, pois nem toda despesa é uma assinatura
        public Assinatura? Assinatura { get; set; }
    }
}
