using PaymentManager.Data.Entities.Enums;
using System;
using System.Collections.Generic;

namespace PaymentManager.Data.Entities.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? ExecutedAt { get; set; }
        public PaymentStatus PaymentStatus { get; set; }

        public int ReceiverCardId { get; set; }
        public Card ReceiverCard { get; set; }

        public ICollection<CardPayment> SenderCardPayments { get; set; }
    }
}
