using Microsoft.EntityFrameworkCore;
using WebApplicationExemplo1.Models;

namespace WebApplicationExemplo1.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Aluno> aluno { get; set; }
        public DbSet<Turma> turma { get; set; }
        public DbSet<Produto> produto { get; set; }
        public DbSet<UnidadeMedida> unidadeMedida { get; set; }
    }
}
