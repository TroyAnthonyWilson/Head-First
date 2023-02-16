namespace PickRandomCards
{
    public class CardPicker
    {
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            int counter = 0;
            int counter2 = 0;

            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
                
                if (i > 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        counter2++;
                        if (pickedCards[i] == pickedCards[j])
                        {
                            i--;
                        }
                    }
                }
                counter++;
            }
            Console.WriteLine(counter);
            Console.WriteLine(counter2);
            return pickedCards;
        }

        private static string RandomSuit()
        {
            string[] suits = new string[] { "Hearts", "Diamonds", "Clubs", "Spades" };
            Random random = new Random();
            int randomIndex = random.Next(0, suits.Length);
            return suits[randomIndex];
        }

        private static string RandomValue()
        {
            string[] value = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            Random random = new Random();
            int randomIndex = random.Next(0, value.Length);
            return value[randomIndex];
        }
    }
}
