namespace OrusFinancas.Data
{
    // Representa serviços recorrentes (que geram Despesas).
    public class Assinatura
    {
        public int Id { get; set; }
        public string NomeServico { get; set; } = string.Empty;
        public decimal Custo { get; set; }
        public string Frequencia { get; set; } = string.Empty; // Ex: "Mensal", "Anual"
        public DateTime ProximoVencimento { get; set; }
        
        // Relacionamento 1:N com Usuario
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        // Relacionamento 1:N com Despesas (Assinatura gera Despesas)
        public ICollection<Despesa> DespesasGeradas { get; set; } = new List<Despesa>();
    }
}