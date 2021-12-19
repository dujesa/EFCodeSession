using PaymentManager.Data.Entities.Enums;
using PaymentManager.Data.Entities.Models;
using PaymentManager.Domain.Models;
using PaymentManager.Presentation.Extensions;
using System;
using System.Collections.Generic;

namespace PaymentManager.Presentation.Helpers
{
    public static class Printer
    {
        public static void DisplayUser(User user)
        {
            Console.WriteLine($"[{user.Oib}] \t {user.FirstName} {user.LastName}");
        }

        public static void DisplayUsers(ICollection<User> users)
        {
            foreach (var user in users)
            {
                DisplayUser(user);
            }
        }

        public static void DisplayPayment(Payment payment) => Console.WriteLine($"ID: {payment.Id} \t [Exectution date: {payment.ExecutedAt?.ToShortDateString()}] \t {payment.Description}");
        public static void DisplayPaymentDetails(PaymentDetails paymentDetails)
        {
            if (paymentDetails is null)
            {
                Console.WriteLine("Details were unavailable");
                return;
            }


            var executionDateTime = paymentDetails.ExecutedAt ?? DateTime.UnixEpoch;
            var daysUntilExecution = (DateTime.Now - executionDateTime).Days;
            var isBillable = paymentDetails.PaymentStatus.IsOneOf(PaymentStatus.Pending, PaymentStatus.Complete);

            Console.WriteLine("-------------------------");


            if (isBillable)
            {
                var executionDetails = daysUntilExecution < 0
                    ? $"Execution in {Math.Abs(daysUntilExecution)} days"
                    : $"Executed before {daysUntilExecution} days";

                Console.WriteLine($"[{executionDetails}]\n");
            }


            Console.WriteLine(
                $"@{paymentDetails.PaymentStatus} \n" +
                $"\t From: {string.Join(", ", paymentDetails.SenderFullNames)}\n" +
                $"\t To: {paymentDetails.ReceiverFullName}\n" +
                $"\t Amount: {paymentDetails.Amount} HRK");
        }

        public static void DisplayPayments(ICollection<Payment> payments)
        {
            foreach (var payment in payments)
            {
                DisplayPayment(payment);
            }
        }

        public static void WaitForExit()
        {
            Console.ReadLine();
            Console.Clear();
        }
    }
}
