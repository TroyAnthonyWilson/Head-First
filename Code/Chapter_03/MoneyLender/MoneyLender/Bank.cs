namespace MoneyLender
{
    public class Bank
    {

        public static void TransferCash(Guy giver, Guy receiver, int amount)
        {
            if (amount < 1)
            {
                Console.Write("You can't give less then one buck.");
                return;
            }
            if (giver.DoIHaveEnoughCash(amount))
            {
                Console.Write($"{giver} does not have enough cash.");
                return;
            }
            giver.GiveCash(amount);
            receiver.ReceiveCash(amount);
            Console.Write($"{giver.Name} gave {receiver.Name} {amount} bucks.");
        }
    }
}
