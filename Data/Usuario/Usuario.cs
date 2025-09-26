namespace OrusFinancas.Data
{
    // Representa o usuário principal do sistema.
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        
        // Relacionamentos (coleções para o Entity Framework Core)
        public ICollection<Conta> Contas { get; set; } = new List<Conta>();
        public ICollection<Orcamento> Orcamentos { get; set; } = new List<Orcamento>();
        public ICollection<InsightFinanceiro> InsightsRecebidos { get; set; } = new List<InsightFinanceiro>();
        public ICollection<Assinatura> Assinaturas { get; set; } = new List<Assinatura>();
    }
}

