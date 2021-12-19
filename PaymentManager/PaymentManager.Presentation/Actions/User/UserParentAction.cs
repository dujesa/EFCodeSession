using PaymentManager.Presentation.Abstractions;
using System;
using System.Collections.Generic;

namespace PaymentManager.Presentation.Actions.User
{
    public class UserParentAction : ParentActionBase
    {
        public UserParentAction(IList<IAction> actions) : base(actions)
        {
            Label = "Manage users";
        }

        public override void Call()
        {
            Console.WriteLine("Users management");
            base.Call();
        }
    }
}
