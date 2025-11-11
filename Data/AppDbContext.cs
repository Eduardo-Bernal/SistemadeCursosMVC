using SistemaDeCursoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaDeCursoMVC.Data
{
    public class AppDbContext : DbContext
    {
        // Recebendo as opcoes de configuracao do banco
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        //Direciona a clase Curso para a TabelaCurso no Banco de dados
        public DbSet<Curso> TabelaCurso { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
            .HasDiscriminator<string>("Tipo")
            .HasValue<Tecnico>("Tecnico")
            .HasValue<Superior>("Superior");
        }
    }
}