namespace GamblingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy player = new Guy("Player", 100);
            double odds = 0.9;
            int winCount = 0;
            int loseCount = 0;

            do
            {
                int pot = 0;
                bool validNumber = false;
                //Console.Clear();
                do
                {
                    if (player.GetCashAmount() == 0)
                    {
                        Console.WriteLine("You are out of cash");
                        Console.WriteLine($"Win count = {winCount}");
                        Console.WriteLine($"Lose count = {loseCount}");
                        Environment.Exit(0);
                    }
                    player.WriteMyInfo();
                    Console.Write("How much money would you like to bet? ");
                    string input = "1";
                    if (int.TryParse(input, out int amount))
                    {
                        if (player.DoIHaveEnoughCash(amount))
                        {
                            Console.WriteLine($"You bet {amount}");
                            pot = amount * 2;
                            player.GiveCash(amount);
                            validNumber = true;
                        }
                        else
                        {
                            Console.WriteLine("Sorry you don't have enough cash.");
                        }
                    }
                } while (!validNumber);

                Console.WriteLine($"The pot is {pot}");
                Console.WriteLine($"The odds are {odds}");
                Random random = new Random();
                double winningNumber = random.NextDouble();
                if (winningNumber < odds)
                {
                    Console.WriteLine("Sorry you lose.");
                    loseCount++;
                    pot = 0;
                }
                else
                {
                    Console.WriteLine("You win!!");
                    winCount++;
                    player.ReceiveCash(pot);
                }
                //Console.WriteLine("Press any key to play again");
                //Console.ReadLine();

            } while (true);
        }
    }
}