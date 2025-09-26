namespace OrusFinancas.Data
{
    // Usada para classificar Transações (ex: "Alimentação", "Salário", "Transporte").
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty; // "Receita" ou "Despesa"
        
        // Relacionamento 1:N com Transacao
        public ICollection<Transacao> Transacoes { get; set; } = new List<Transacao>();

        // Relacionamento 1:N com Usuario (o usuário cria a categoria)
        public int UsuarioId { get; set; } 
        public Usuario? Usuario { get; set; } 
    }
}
