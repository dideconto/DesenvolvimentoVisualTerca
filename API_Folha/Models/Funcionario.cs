using System;

namespace API.Models
{
    public class Funcionario
    {
        public Funcionario () => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}