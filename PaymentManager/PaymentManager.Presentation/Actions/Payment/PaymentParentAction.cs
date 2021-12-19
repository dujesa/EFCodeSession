using PaymentManager.Presentation.Abstractions;
using System;
using System.Collections.Generic;

namespace PaymentManager.Presentation.Actions.Payment
{
    public class PaymentParentAction : ParentActionBase
    {
        public PaymentParentAction(IList<IAction> actions) : base(actions)
        {
            Label = "Manage payments";
        }

        public override void Call()
        {
            Console.WriteLine("Payments management");
            base.Call();
        }
    }
}
