namespace PickRandomCards
{
    internal class Program
    {
        static void Main()
        {
            int numOfCards = GetNumOfCards();

            
            List<string> cards = CardPicker.PickSomeCards(numOfCards);
            PrintCards(cards);
        }

        private static void PrintCards(List<string> cards)
        {
            foreach (string card in cards)
            {
                Console.WriteLine(card);
            }
        }


        private static int GetNumOfCards()
        {
            bool isNumber;
            int numOfCards;
            
            do
            {
                Console.Write("How many cards do you want to pick? : ");
                string howManyCards = Console.ReadLine();
                Console.Clear();
                isNumber = int.TryParse(howManyCards, out numOfCards);
                if (!isNumber || numOfCards < 1 || numOfCards > 52)
                    {
                        Console.WriteLine("Please enter a number between 1 and 52");
                        isNumber = false;
                    }
                } while (!isNumber);
            Console.Clear();
            return numOfCards;
        }
    }
}