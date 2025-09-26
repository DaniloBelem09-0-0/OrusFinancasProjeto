namespace OrusFinancas.Data
{
    // Representa um limite de gastos para uma Categoria em um período.
    public class Orcamento
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal ValorLimite { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        // Relacionamento 1:N com Usuario
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
