using Microsoft.EntityFrameworkCore;

namespace ExchangeWidget.Database;

public partial class CurrencyContext : DbContext
{
    public CurrencyContext()
    {
        Database.EnsureCreated();
    }


    public virtual DbSet<Favorite> Favorites { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=Currency.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Favorite>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.HasIndex(e => e.Code, "IX_Favorites_Code").IsUnique();

            entity.Property(e => e.Code).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
