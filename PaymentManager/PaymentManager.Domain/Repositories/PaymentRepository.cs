using PaymentManager.Data.Entities;
using PaymentManager.Data.Entities.Models;
using PaymentManager.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace PaymentManager.Domain.Repositories
{
    public class PaymentRepository : RepositoryBase
    {
        public PaymentRepository(PaymentManagerDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(Payment payment)
        {
            DbContext.Payments.Add(payment);

            return SaveChanges();
        }

        public ResponseResultType Edit(Payment payment, int paymentId)
        {
            var edittingPayment = DbContext.Payments.Find(paymentId);
            if (edittingPayment is null)
            {
                return ResponseResultType.NotFound;
            }

            edittingPayment.PaymentStatus = payment.PaymentStatus;
            edittingPayment.Description = payment.Description;
            edittingPayment.ExecutedAt = payment.ExecutedAt;

            return SaveChanges();
        }

        public ResponseResultType Delete(int paymentId)
        {
            var deletingPayment = DbContext.Payments.Find(paymentId);
            if (deletingPayment is null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.Payments.Remove(deletingPayment);

            return SaveChanges();
        }

        public ICollection<Payment> GetAll() => DbContext.Payments.ToList();
    }
}
