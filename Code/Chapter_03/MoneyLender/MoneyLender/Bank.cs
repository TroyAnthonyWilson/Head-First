using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLender
{
    public class Bank
    {

        public static void TransferCash(Guy giver, Guy receiver, int amount)
        {
            if (amount < 1)
            {
                Console.WriteLine("You can't give less then one buck.");
                return;
            }
            if (giver.DoIHaveEnoughCash(amount))
            {
                Console.WriteLine($"{giver} does not have enough cash.");
                return;
            }
            giver.GiveCash(amount);
            receiver.ReceiveCash(amount);
            Console.WriteLine($"{giver.Name} gave {receiver.Name} {amount} bucks.");
        }
    }
}
