namespace OrusFinancas.Data
{
    // Armazena dados de alto nível ou metas financeiras do usuário.
    public class PerfilFinanceiro
    {
        public int Id { get; set; }
        public decimal MetaEconomiaMensal { get; set; }
        public string NivelRisco { get; set; } = string.Empty; // Ex: "Conservador", "Moderado"
        
        // Relacionamento 1:1 com Usuario (chave primária/estrangeira)
        public int UsuarioId { get; set; } 
        public Usuario? Usuario { get; set; }
    }
}