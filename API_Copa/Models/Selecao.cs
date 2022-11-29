using System;

namespace API_Copa.Models
{
    public class Selecao
    {
        public Selecao() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
