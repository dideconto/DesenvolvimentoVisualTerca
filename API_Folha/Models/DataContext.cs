
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    //Entity Framework Code First
    //É a classe que define a estrutura do banco de dados
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options) { }

        //Definir quais as classes de modelo servirão para as         
        //tabelas no banco de dados
        public DbSet<Funcionario> Funcionarios { get; set; } 

        public DbSet<FolhaPagamento> Folhas { get; set; }
    }
}