namespace OrusFinancas.Data
{
    // Representa uma entrada de dinheiro.
    public class Receita : Transacao
    {
        public string Fonte { get; set; } = string.Empty; // Ex: "Salário Fixo", "Freelance"
        public bool Recorrente { get; set; } // Se é uma receita que se repete
    }
}
