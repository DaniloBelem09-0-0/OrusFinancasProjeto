using OrusFinancas.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Server; // <-- Adicionando o using específico

var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços Blazor (UI) e de Componentes
builder.Services.AddRazorComponents().AddInteractiveWebAssemblyRenderMode()


// 1. Adiciona o suporte a Controllers API (o C do MVC/API)
builder.Services.AddControllers(); 

// 2. CORREÇÃO: Remove o AddHttpClient() e Adiciona uma configuração que define o BaseAddress.
// **CORREÇÃO TEMPORÁRIA:** Alterado para a porta HTTP (5067) para contornar problemas de certificado HTTPS/confiança.
// Assim que o certificado for confiável (passo 2), isso deve ser revertido para HTTPS (7145).
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5067/") });


var app = builder.Build();

// Configure o pipeline de requisições HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // Configuração HSTS
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Importante: Garante que arquivos estáticos (CSS, JS) sejam servidos
app.UseAntiforgery();

// 3. Mapeia os endpoints dos Controllers API
app.MapControllers();

// Mapeia os componentes Blazor
// CORREÇÃO AQUI: Usamos uma sobrecarga que, com as referências do .csproj, funciona
app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode(); 

app.Run();
