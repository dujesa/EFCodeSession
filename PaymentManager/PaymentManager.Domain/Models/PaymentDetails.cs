using PaymentManager.Data.Entities.Enums;
using System;
using System.Collections.Generic;

namespace PaymentManager.Domain.Models
{
    public class PaymentDetails
    {
        public string ReceiverFullName { get; set; }
        public ICollection<string> SenderFullNames { get; set; }
        public decimal Amount { get; set; }
        public DateTime? ExecutedAt { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }
}
