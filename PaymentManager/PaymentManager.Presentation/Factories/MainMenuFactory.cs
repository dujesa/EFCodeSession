using PaymentManager.Presentation.Abstractions;
using PaymentManager.Presentation.Actions;
using PaymentManager.Presentation.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentManager.Presentation.Factories
{
    public class MainMenuFactory
    {
        public static IList<IAction> GetMainMenuActions()
        {
            var actions = new List<IAction>
            {
                DashboardActionsFactory.Create(),
                new ExitMenuAction()
            };

            actions.SetActionIndexes();
            return actions;
        }
    }
}
