using System;

namespace API_Copa.Models
{
    public class Jogo
    {
        public Jogo() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public int? SelecaoAId { get; set; }
        public Selecao SelecaoA { get; set; }
        public int PlacarA { get; set; }
        public int? SelecaoBId { get; set; }
        public Selecao SelecaoB { get; set; }
        public int PlacarB { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
