using System;

namespace PaymentManager.Data.Entities.Models
{
    public class CardPayment
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public int CardId { get; set; }
        public Card Card { get; set; }

        public int PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}
