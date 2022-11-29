using API_Copa.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Selecao> Selecoes { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
    }
}