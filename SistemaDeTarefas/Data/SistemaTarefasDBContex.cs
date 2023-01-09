using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data
{
    // Herda de DbContext fazendo um import em cima no using
    public class SistemaTarefasDBContex : DbContext
    {
        // criação do construtor extraindo da variavel options
        public SistemaTarefasDBContex(DbContextOptions<SistemaTarefasDBContex> options)
            : base(options)
        {
        }

        // representa uma tabela no banco
        public DbSet<UsuarioModel> Usuarios { get; set; }

        // outra tabela
        public DbSet<TarefaModel> Tarefas { get; set; }

        // criação de método com parâmetro ModelBuilder e variavel
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
