using PaymentManager.Domain.Repositories;
using PaymentManager.Presentation.Abstractions;
using PaymentManager.Presentation.Helpers;
using System;

namespace PaymentManager.Presentation.Actions.Dashboard
{
    public class DashboardPaymentDetails : IAction
    {
        private readonly CardPaymentRepository _cardPaymentRepository;
        private readonly PaymentRepository _paymentRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "List payment details by id";

        public DashboardPaymentDetails(CardPaymentRepository cardPaymentRepository, PaymentRepository paymentRepository)
        {
            _cardPaymentRepository = cardPaymentRepository;
            _paymentRepository = paymentRepository;
        }

        public void Call()
        {
            var payments = _paymentRepository.GetAll();
            Printer.DisplayPayments(payments);
            Console.WriteLine("Enter payment id or exit");
            var isRead = Reader.TryReadNumber(out var paymentId);
            if (!isRead)
                return;

            var paymentDetails = _cardPaymentRepository.GetPaymentDetails(paymentId);
            Printer.DisplayPaymentDetails(paymentDetails);

            Printer.WaitForExit();
        }
    }
}
