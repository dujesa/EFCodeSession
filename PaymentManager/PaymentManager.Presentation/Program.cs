using PaymentManager.Presentation.Extensions;
using PaymentManager.Presentation.Factories;

namespace PaymentManager.Presentation
{
    public class Program
    {
        static void Main()
        {
            var mainMenuActions = MainMenuFactory.GetMainMenuActions();
            mainMenuActions.PrintActionsAndCall();
        }
    }
}
