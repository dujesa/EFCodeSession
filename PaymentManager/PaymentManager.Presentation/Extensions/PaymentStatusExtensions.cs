using PaymentManager.Data.Entities.Enums;
using System;
using System.Linq;

namespace PaymentManager.Presentation.Extensions
{
    public static class PaymentStatusExtensions
    {
        public static bool IsOneOf(this PaymentStatus paymentStatus, params PaymentStatus[] statusesForCheck)
        {
            return statusesForCheck.Contains(paymentStatus);
        }
    }
}
