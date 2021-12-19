using PaymentManager.Domain.Factories;
using PaymentManager.Domain.Repositories;
using PaymentManager.Presentation.Abstractions;
using PaymentManager.Presentation.Actions;
using PaymentManager.Presentation.Actions.Dashboard;
using System.Collections.Generic;

namespace PaymentManager.Presentation.Factories
{
    public class DashboardActionsFactory
    {
        public static DashboardParentAction Create()
        {
            var actions = new List<IAction>
            {
                new DashboardAllPayments(RepositoryFactory.Create<PaymentRepository>()),
                new DashboardPaymentDetails(RepositoryFactory.Create<CardPaymentRepository>(), RepositoryFactory.Create<PaymentRepository>()),
                new ExitMenuAction()
            };

            var dashboardActions = new DashboardParentAction(actions);
            return dashboardActions;
        }
    }
}
