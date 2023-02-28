namespace MoneyLender
{
    public class Guy
    {
        public readonly string Name;
        private int Cash;

        public Guy(string name, int cash)
        {
            Name = name;
            Cash = cash;
        }

        /// <summary>
        /// Receives cash from someone else
        /// </summary>
        /// <param name="amount">The amount to be received</param>
        public void ReceiveCash(int amount)
        {
            Cash += amount;
        }

        /// <summary>
        /// Gives cash to another guy
        /// </summary>
        /// <param name="amount">The amount that will be given</param>
        /// <param name="receiver">Who will recive the cash</param>
        public void GiveCash(int amount)
        {
            Cash -= amount;
        }

        /// <summary>
        /// Writes my name and the amount of cash to the console
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine($"{Name} has {Cash} bucks");
        }


        /// <summary>
        /// Do I have enough cash?
        /// </summary>
        /// <returns>The amount of cash in my pocket</returns>
        public bool DoIHaveEnoughCash(int amount)
        {
            return amount > Cash;
        }

        public int GetCashAmount()
        {
            return Cash;
        }
    }
}
