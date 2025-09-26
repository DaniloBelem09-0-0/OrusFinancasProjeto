using Microsoft.AspNetCore.Mvc;
using OrusFinancas.Data;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    // private readonly IAuthService _authService; // RNF03: Injeção de serviço de segurança
    
    // RF01: Permitir o cadastro de novos usuários.
    [HttpPost("cadastro")]
    public async Task<ActionResult<AuthResponse>> Cadastro([FromBody] CadastroRequest request)
    {
        // RNF03 (Segurança):
        // 1. Validar se o e-mail não existe no BD.
        // 2. Hash da senha (nunca salvar a senha em texto plano).
        
        if (request.Senha.Length < 6)
        {
            // RNF03: Implementar regras de senha forte.
            return BadRequest(new AuthResponse { Sucesso = false, Mensagem = "A senha deve ter pelo menos 6 caracteres." });
        }
        
        // Simulação de criação de usuário no BD (RNF02: Assíncrono)
        
        return await Task.FromResult(Ok(new AuthResponse 
        { 
            Sucesso = true, 
            Mensagem = "Usuário cadastrado com sucesso. Efetue o login." 
        }));
    }

    // RF02: Permitir o login de usuários existentes.
    [HttpPost("login")]
    public async Task<ActionResult<AuthResponse>> Login([FromBody] LoginRequest request)
    {
        // RNF03 (Segurança):
        // 1. Buscar usuário pelo e-mail.
        // 2. Verificar se o hash da senha corresponde.
        
        if (request.Email != "teste@orius.com" || request.Senha != "123456") 
        {
            // RNF03: Evitar dar dicas sobre o que falhou (email ou senha).
            return Unauthorized(new AuthResponse { Sucesso = false, Mensagem = "Credenciais inválidas." });
        }

        // Se a autenticação for bem-sucedida:
        // RNF03: Gerar um token JWT (ou cookie de autenticação) para manter o usuário logado.
        
        return await Task.FromResult(Ok(new AuthResponse 
        { 
            Sucesso = true, 
            Mensagem = "Login realizado com sucesso.",
            Token = "SEU_TOKEN_JWT_AQUI" 
        }));
    }

    // RNF03: Endpoint para sair do sistema (logout)
    [HttpPost("logout")]
    public async Task<IActionResult> Logout()
    {
        // RNF03: Lógica para invalidar o token/cookie de sessão.
        return await Task.FromResult(NoContent());
    }
}
