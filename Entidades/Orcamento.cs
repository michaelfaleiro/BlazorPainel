using System.ComponentModel.DataAnnotations;

namespace BlazorPainel.Entidades
{
    public class Orcamento
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome Obrigatório")]
        public string? Cliente { get; set; }
        [Required(ErrorMessage = "Informe o Carro")]
        public string? Carro { get; set; }
        public string? Placa { get; set; }
        public string? Chassi { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DateAtualizacao { get; set; }
    }
}