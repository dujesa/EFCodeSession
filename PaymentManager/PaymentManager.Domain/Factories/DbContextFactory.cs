using Microsoft.EntityFrameworkCore;
using PaymentManager.Data.Entities;
using System.Configuration;

namespace PaymentManager.Domain.Factories
{
    public static class DbContextFactory
    {
        public static PaymentManagerDbContext GetPaymentManagerDbContext()
        {
            var options = new DbContextOptionsBuilder()
                .UseSqlServer(ConfigurationManager.ConnectionStrings["PaymentManager"].ConnectionString)
                .Options;

            return new PaymentManagerDbContext(options);
        }
    }
}