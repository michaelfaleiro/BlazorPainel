using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorPainel;
using BlazorPainel.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazorBootstrap();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7177/v1/api/") });
builder.Services.AddScoped<IOrcamentoService, OrcamentoService>();



await builder.Build().RunAsync();
