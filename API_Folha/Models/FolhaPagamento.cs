using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class FolhaPagamento
    {
        public FolhaPagamento() =>
            CriadoEm = DateTime.Now;

        [Key]
        public int Id { get; set; }
        public double ValorHora { get; set; }
        public int QuantidadeHoras { get; set; }
        public double SalarioBruto { get; set; }
        public double ImpostoRenda { get; set; }
        public double ImpostoInss { get; set; }
        public double ImpostoFgts { get; set; }
        public double SalarioLiquido { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public DateTime CriadoEm { get; set; }

        //Relacionamento
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}