namespace OrusFinancas.Data
{
    // DTO para cadastro de novos usuários (RF01)
    public class CadastroRequest
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    }

    // DTO para login de usuários (RF02)
    public class LoginRequest
    {
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    }

    // DTO de resposta (token ou status)
    public class AuthResponse
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public string? Token { get; set; } // Se usarmos JWT
    }
}
