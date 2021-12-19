using PaymentManager.Data.Entities;
using PaymentManager.Data.Entities.Models;
using PaymentManager.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace PaymentManager.Domain.Repositories
{
    public class CardRepository : RepositoryBase
    {
        public CardRepository(PaymentManagerDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(Card card)
        {
            DbContext.Cards.Add(card);

            return SaveChanges();
        }

        public ResponseResultType Edit(Card card, int cardId)
        {
            var edittingCard = DbContext.Cards.Find(cardId);
            if (edittingCard is null)
            {
                return ResponseResultType.NotFound;
            }

            edittingCard.Iban = card.Iban;
            edittingCard.Balance = card.Balance;

            return SaveChanges();
        }

        public ResponseResultType Delete(int cardId)
        {
            var deletingCard = DbContext.Cards.Find(cardId);
            if (deletingCard is null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.Cards.Remove(deletingCard);

            return SaveChanges();
        }

        public ICollection<Card> GetAll() => DbContext.Cards.ToList();
    }
}
