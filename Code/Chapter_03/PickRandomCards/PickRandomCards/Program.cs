﻿namespace PickRandomCards
{
    internal class Program
    {
        static void Main()
        {
            int numOfCards = GetNumOfCards();

            
            string[] cards = CardPicker.PickSomeCards(numOfCards);
            PrintCards(cards);
        }

        private static void PrintCards(string[] cards)
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
                Console.WriteLine("How many cards do you want to pick?");
                string numberOfCards = Console.ReadLine();
                isNumber = int.TryParse(numberOfCards, out numOfCards);
                if (!isNumber)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a number");
                }
                else if (numOfCards < 1 || numOfCards > 52)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a number between 1 and 52");
                    isNumber = false;
                }
                } while (!isNumber);
            Console.Clear();
            return numOfCards;
        }
    }
}