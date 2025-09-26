// Controllers/TransacoesController.cs
using Microsoft.AspNetCore.Mvc;
using OrusFinancas.Data;

[Route("api/Transacoes")] // Define a rota como /api/transacoes
[ApiController]
public class TransacoesController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Transacao>> GetTransacoes()
    {
        // Simulação de dados do "Model" (futuro acesso ao BD)
        var transacoes = new List<Transacao>
        {
            new Transacao { Id = 1, Descricao = "Salário", Valor = 5000.00m, Data = DateTime.Now.AddDays(-5) },
            new Transacao { Id = 2, Descricao = "Aluguel", Valor = -1500.00m, Data = DateTime.Now.AddDays(-3) }
        };

        return Ok(transacoes); // Retorna os dados em JSON
    }
}