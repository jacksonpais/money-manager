using Microsoft.EntityFrameworkCore;
using money.data.Seeds;
using money.domain.Entities;
using System.Text.Json;

namespace money.data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<TransactionTypeMaster> TransactionTypeMaster { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedConfiguration.AddSeedData(modelBuilder);
        }
    }
}