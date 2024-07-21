using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Geempe.Infra.Context;

public class AppDBContext(IConfiguration _configuration) : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }

    //public DbSet<DDD> DDD { get; set; }
    //public DbSet<Contato> Contatos { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreatedAt") != null))
        {
            if (entry.State == EntityState.Modified)
            {
                entry.Property("CreatedAt").IsModified = false;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }

}
