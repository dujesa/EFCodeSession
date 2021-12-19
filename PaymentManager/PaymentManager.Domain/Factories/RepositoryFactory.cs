using PaymentManager.Domain.Repositories;
using System;

namespace PaymentManager.Domain.Factories
{
    public class RepositoryFactory
    {
        public static TRepository Create<TRepository>() where TRepository : RepositoryBase
        {
            var context = DbContextFactory.GetPaymentManagerDbContext();
            var repositoryInstance = Activator
                .CreateInstance(typeof(TRepository), context) as TRepository;
        
            return repositoryInstance;
        }
    }
}
