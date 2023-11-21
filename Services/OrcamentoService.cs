using System.Net;
using System.Net.Http.Json;
using BlazorPainel.Entidades;
using Microsoft.AspNetCore.Components;

namespace BlazorPainel.Services
{
    public class OrcamentoService : IOrcamentoService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public OrcamentoService(HttpClient httpClient, NavigationManager navigationManager)
        {
            _http = httpClient;
            _navigationManager = navigationManager;
        }
        public List<Orcamento> Orcamentos { get; set; } = [];

        public async Task CreateOrcamento(Orcamento orcamento)
        {
            await _http.PostAsJsonAsync("orcamentos", orcamento);
            _navigationManager.NavigateTo("orcamentos");

        }

        public async Task DeleteOrcamento(int id)
        {
            await _http.DeleteAsync($"orcamentos/{id}");
            _navigationManager.NavigateTo("orcamentos");
        }

        public async Task<Orcamento?> GetOrcamentoById(int id)
        {
            var result = await _http.GetAsync($"orcamentos/{id}");
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return await result.Content.ReadFromJsonAsync<Orcamento>();
            }
            return null;
        }

        public async Task GetOrcamentos()
        {
            var result = await _http.GetFromJsonAsync<List<Orcamento>>("orcamentos");
            if (result is not null)
            {
                Orcamentos = result;
            }


        }

        public async Task UpdateOrcamento(int id, Orcamento orcamento)
        {
            await _http.PutAsJsonAsync($"orcamentos/{id}", orcamento);
            _navigationManager.NavigateTo("orcamentos");
        }
    }
}