using PaymentManager.Presentation.Extensions;
using System.Collections.Generic;

namespace PaymentManager.Presentation.Abstractions
{
    public class ParentActionBase : IParentAction
    {
        public int MenuIndex { get; set; }
        public string Label { get; set; }
        public IList<IAction> Actions { get; set; }

        public ParentActionBase(IList<IAction> actions)
        {
            actions.SetActionIndexes();
            Actions = actions;
        }

        public virtual void Call()
        {
            Actions.PrintActionsAndCall();
        }
    }
}
