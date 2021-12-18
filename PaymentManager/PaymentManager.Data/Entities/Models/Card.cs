using System;
using System.Collections.Generic;

namespace PaymentManager.Data.Entities.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Iban { get; set; }
        public decimal Balance { get; set; }
        public DateTime ExpiresAt { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<CardPayment> CardPayments { get; set; }
    }
}
