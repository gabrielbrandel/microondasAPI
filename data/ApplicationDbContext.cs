using Microsoft.EntityFrameworkCore;

namespace Microondas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext() { }
        public DbSet<Programado> Programados { get; set; }
    }

    public class Programado
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Alimento { get; set; }
        public string? Tempo { get; set; }
        public int? Potencia { get; set; }
        public string? Instrucao { get; set; }
    }
}
