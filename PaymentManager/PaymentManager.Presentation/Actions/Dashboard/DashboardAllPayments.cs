using PaymentManager.Domain.Repositories;
using PaymentManager.Presentation.Abstractions;
using PaymentManager.Presentation.Helpers;

namespace PaymentManager.Presentation.Actions.Dashboard
{
    public class DashboardAllPayments : IAction
    {
        private readonly PaymentRepository _paymentRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "List all payments";

        public DashboardAllPayments(PaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public void Call()
        {
            var payments = _paymentRepository.GetAll();

            Printer.DisplayPayments(payments);
            Printer.WaitForExit();
        }
    }
}
