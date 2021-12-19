using PaymentManager.Presentation.Abstractions;
using PaymentManager.Presentation.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PaymentManager.Presentation.Extensions
{
    public static class ActionExtensions
    {
        public static void PrintActionsAndCall(this IList<IAction> actions)
        {
            var isExitSelected = false;
            do
            {
                PrintActions(actions);

                var isInputInteger = int.TryParse(Console.ReadLine(), out var actionIndex);
                if (!isInputInteger)
                {
                    Console.WriteLine("Please type in number.");
                    Thread.Sleep(1000);
                    Console.Clear();

                    continue;
                }

                var action = actions.FirstOrDefault(a => a.MenuIndex == actionIndex);
                if (action is null)
                {
                    Console.WriteLine("Please select valid action.");
                    Thread.Sleep(1000);
                    Console.Clear();

                    continue;
                }

                action.Call();
                isExitSelected = action is ExitMenuAction;

            } while (!isExitSelected);
        }

        public static void SetActionIndexes(this IList<IAction> actions)
        {
            var index = 0;
            foreach (var action in actions)
            {
                action.MenuIndex = ++index;
            }
        }

        private static void PrintActions(IList<IAction> actions)
        {
            foreach (var action in actions)
            {
                Console.WriteLine($"{action.MenuIndex}. {action.Label}");
            }
        }
    }
}
