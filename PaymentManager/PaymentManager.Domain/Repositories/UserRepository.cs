using PaymentManager.Data.Entities;
using PaymentManager.Data.Entities.Models;
using PaymentManager.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace PaymentManager.Domain.Repositories
{
    public class UserRepository : RepositoryBase
    {
        public UserRepository(PaymentManagerDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(User user)
        {
            DbContext.Users.Add(user);

            return SaveChanges();
        }

        public ResponseResultType Edit(User user, int userId)
        {
            var edittingUser = DbContext.Users.Find(userId);
            if (edittingUser is null)
            {
                return ResponseResultType.NotFound;
            }

            edittingUser.Oib = user.Oib;
            edittingUser.FirstName = user.FirstName;
            edittingUser.LastName = user.LastName;

            return SaveChanges();
        }

        public ResponseResultType Delete(int userId)
        {
            var deletingUser = DbContext.Users.Find(userId);
            if (deletingUser is null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.Users.Remove(deletingUser);

            return SaveChanges();
        }

        public ICollection<User> GetAll() => DbContext.Users.ToList();
    }
}
