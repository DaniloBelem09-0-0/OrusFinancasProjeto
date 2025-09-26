namespace OrusFinancas.Data
{
    // Feedback ou alerta gerado pelo sistema para o usuário.
    public class InsightFinanceiro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Mensagem { get; set; } = string.Empty;
        public DateTime DataGeracao { get; set; }
        public bool Lido { get; set; }
        
        // Relacionamento 1:N com Usuario
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
