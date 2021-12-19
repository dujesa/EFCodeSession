using Microsoft.EntityFrameworkCore;
using PaymentManager.Data.Entities;
using PaymentManager.Domain.Models;
using System.Linq;

namespace PaymentManager.Domain.Repositories
{
    public class CardPaymentRepository : RepositoryBase
    {
        public CardPaymentRepository(PaymentManagerDbContext dbContext) : base(dbContext)
        {
        }

        public PaymentDetails GetPaymentDetails(int paymentId)
        {
            var senderDetails = DbContext.CardPayments
                .Include(cp => cp.Card)
                .ThenInclude(c => c.User)
                .Where(cp => cp.PaymentId == paymentId)
                .Select(cp => new
                {
                    cp.Amount,
                    SenderFullName = $"{ cp.Card.User.FirstName} {cp.Card.User.LastName}",
                });

            var receiverDetails = DbContext.Payments
                .Include(p => p.ReceiverCard)
                .ThenInclude(rc => rc.User)
                .Where(p => p.Id == paymentId)
                .Select(rd => new
                {
                    ReceiverFullName = $"{rd.ReceiverCard.User.FirstName} {rd.ReceiverCard.User.LastName}",
                    rd.ExecutedAt,
                    rd.PaymentStatus
                })
                .FirstOrDefault();

            if (receiverDetails is null || senderDetails is null)
            {
                return null;
            }

            var paymentDetails = senderDetails
                .Select(sd => new PaymentDetails
                {
                    Amount = senderDetails.Sum(p => p.Amount),
                    ReceiverFullName = receiverDetails.ReceiverFullName,
                    SenderFullNames = senderDetails.Select(details => details.SenderFullName).ToList(),
                    ExecutedAt = receiverDetails.ExecutedAt,
                    PaymentStatus = receiverDetails.PaymentStatus
                })
                .FirstOrDefault();

            return paymentDetails;
        }
    }
}
