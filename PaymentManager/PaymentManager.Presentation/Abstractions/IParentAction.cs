using System.Collections.Generic;

namespace PaymentManager.Presentation.Abstractions
{
    public interface IParentAction : IAction
    {
        IList<IAction> Actions { get; set; }
    }
}
