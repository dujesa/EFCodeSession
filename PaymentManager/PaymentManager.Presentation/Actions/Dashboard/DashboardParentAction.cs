using PaymentManager.Presentation.Abstractions;
using System.Collections.Generic;

namespace PaymentManager.Presentation.Actions.Dashboard
{
    public class DashboardParentAction : ParentActionBase
    {
        public DashboardParentAction(IList<IAction> actions) : base(actions)
        {
            Label = "Dashboard";
        }
    }
}
