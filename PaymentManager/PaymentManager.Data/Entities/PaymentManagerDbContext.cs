using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;

namespace PaymentManager.Data.Entities
{
    public class PaymentManagerDbContext : DbContext
    {
        public PaymentManagerDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //DatabaseSeeder.Execute(modelBuilder);
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
                .TryGet("connectionString:add:PaymentManager:connectionString", out var connectionString);

            var options = new DbContextOptionsBuilder<PaymentManagerDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            return new PaymentManagerDbContext(options);
        }
    }
}
