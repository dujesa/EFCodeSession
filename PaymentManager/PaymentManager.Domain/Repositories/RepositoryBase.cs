using PaymentManager.Data.Entities;
using PaymentManager.Domain.Enums;

namespace PaymentManager.Domain.Repositories
{
    public abstract class RepositoryBase
    {
        protected readonly PaymentManagerDbContext DbContext;

        protected RepositoryBase(PaymentManagerDbContext dbContext)
        {
            DbContext = dbContext;
        }

        protected ResponseResultType SaveChanges()
        {
            var hasChanges = DbContext.SaveChanges() > 0;
            if (!hasChanges)
            {
                return ResponseResultType.NoChanges;
            }

            return ResponseResultType.Success;
        }
    }
}
