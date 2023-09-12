using Microsoft.EntityFrameworkCore;
using NotaAlunoApi.Model;

namespace NotaAlunoApi.Data
{
    public class AlunoContext : DbContext
    {
        public AlunoContext(DbContextOptions<AlunoContext> opts) : base(opts) 
        {
        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
