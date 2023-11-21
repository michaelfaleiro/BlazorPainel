using BlazorPainel.Entidades;

namespace BlazorPainel.Services
{
    public interface IOrcamentoService
    {
        List<Orcamento> Orcamentos { get; set; }
        Task GetOrcamentos();
        Task<Orcamento?> GetOrcamentoById(int id);
        Task CreateOrcamento(Orcamento orcamento);
        Task UpdateOrcamento(int id, Orcamento orcamento);
        Task DeleteOrcamento(int id);

    }
}