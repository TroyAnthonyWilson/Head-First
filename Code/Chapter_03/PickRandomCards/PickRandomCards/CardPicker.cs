namespace PickRandomCards
{
    public class CardPicker
    {
        //public static string[] PickSomeCards(int numberOfCards)
        //{
        //    string[] pickedCards = new string[numberOfCards];
        //    int counter = 0;
        //    int counter2 = 0;

        //    for (int i = 0; i < numberOfCards; i++)
        //    {
        //        pickedCards[i] = RandomValue() + " of " + RandomSuit();
                
        //        if (i > 1)
        //        {
        //            for (int j = 0; j < i; j++)
        //            {
        //                counter2++;
        //                if (pickedCards[i] == pickedCards[j])
        //                {
        //                    i--;
        //                }
        //            }
        //        }
        //        counter++;
        //    }
        //    Console.WriteLine(counter);
        //    Console.WriteLine(counter2);
        //    return pickedCards;
        //}

        //private static string RandomSuit()
        //{
        //    string[] suits = new string[] { "Hearts", "Diamonds", "Clubs", "Spades" };
        //    Random random = new();
        //    int randomIndex = random.Next(0, suits.Length);
        //    return suits[randomIndex];
        //}

        //private static string RandomValue()
        //{
        //    string[] value = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        //    Random random = new();
        //    int randomIndex = random.Next(0, value.Length);
        //    return value[randomIndex];
        //}

        public static List<string> PickSomeCards(int numberOfCards)
        {
            List<string> deck = new()
            {
                "Ace of Hearts",
                "2 of Hearts",
                "3 of Hearts",
                "4 of Hearts",
                "5 of Hearts",
                "6 of Hearts",
                "7 of Hearts",
                "8 of Hearts",
                "9 of Hearts",
                "10 of Hearts",
                "Jack of Hearts",
                "Queen of Hearts",
                "King of Hearts",
                "Ace of Diamonds",
                "2 of Diamonds",
                "3 of Diamonds",
                "4 of Diamonds",
                "5 of Diamonds",
                "6 of Diamonds",
                "7 of Diamonds",
                "8 of Diamonds",
                "9 of Diamonds",
                "10 of Diamonds",
                "Jack of Diamonds",
                "Queen of Diamonds",
                "King of Diamonds",
                "Ace of Clubs",
                "2 of Clubs",
                "3 of Clubs",
                "4 of Clubs",
                "5 of Clubs",
                "6 of Clubs",
                "7 of Clubs",
                "8 of Clubs",
                "9 of Clubs",
                "10 of Clubs",
                "Jack of Clubs",
                "Queen of Clubs",
                "King of Clubs",
                "Ace of Spades",
                "2 of Spades",
                "3 of Spades",
                "4 of Spades",
                "5 of Spades",
                "6 of Spades",
                "7 of Spades",
                "8 of Spades",
                "9 of Spades",
                "10 of Spades",
                "Jack of Spades",
                "Queen of Spades",
                "King of Spades"
            };
            List<string> pickedCards = new List<string>();

            for (int i = 0; i < numberOfCards; i++)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, deck.Count);
                pickedCards.Add(deck[randomIndex]);
                deck.RemoveAt(randomIndex);
            }

            return pickedCards;
        }
    }
}
