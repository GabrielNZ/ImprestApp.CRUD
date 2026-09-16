using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
    {
    }

    public DbSet<Emprestimo> Emprestimos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Equipamento> Equipamentos { get; set; }
}