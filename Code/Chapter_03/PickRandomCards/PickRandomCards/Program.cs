namespace PickRandomCards
{
    internal class Program
    {
        static void Main()
        {
            string[] cards =PickSomeCards(5);

            foreach (string card in cards)
            {
                Console.WriteLine(card);
            }
        }

        private static string[] PickSomeCards(int numberOfCards)
        {
            string[] test = { "hi", "there" };
            return test;
        }
    }
}