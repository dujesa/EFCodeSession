using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PaymentManager.Data.Entities.Models;
using PaymentManager.Data.Seeds;
using System.IO;
using System.Linq;

namespace PaymentManager.Data.Entities
{
    public class PaymentManagerDbContext : DbContext
    {
        public PaymentManagerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<CardPayment> CardPayments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<CardPayment>()
                .HasOne(cp => cp.Payment)
                .WithMany(p => p.SenderCardPayments)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<CardPayment>()
                .HasOne(cp => cp.Card)
                .WithMany(c => c.CardPayments)
                .OnDelete(DeleteBehavior.NoAction);



            DatabaseSeeder.Execute(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }

    public class PaymentManagerContextFactory : IDesignTimeDbContextFactory<PaymentManagerDbContext>
    {
        public PaymentManagerDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddXmlFile("App.config")
                .Build();

            configuration
                .Providers
                .First()
                .TryGet("connectionStrings:add:PaymentManager:connectionString", out var connectionString);

            var options = new DbContextOptionsBuilder<PaymentManagerDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            return new PaymentManagerDbContext(options);
        }
    }
}
