namespace PickRandomCards
{
    internal class Program
    {
        static void Main()
        {
            string[] cards = CardPicker.PickSomeCards(5);

            PrintCards(cards);
        }




        private static void PrintCards(string[] cards)
        {
            foreach (string card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}