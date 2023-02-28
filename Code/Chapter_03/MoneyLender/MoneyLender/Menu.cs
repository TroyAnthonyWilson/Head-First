namespace MoneyLender
{
    public class Menu
    {

        public static GuyData guyData = new();

        private static string[] menuOptions = new string[] { 
            "1. Add new guy",
            "2. Transfer cash",
            "3. Print all guys info",
            "4. Exit" };

        public static void PrintMenu()
        {
            int choice = 1;

            do
            {
                for (int i = 0; i < menuOptions.Length; i++)
                {
                    if (choice == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    Console.WriteLine(menuOptions[i]);
                    Console.ResetColor();
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (choice > 0)
                        {
                            choice--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (choice < menuOptions.Length - 1)
                        {
                            choice++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        switch (choice)
                        {
                            case 0:
                                guyData.AddGuy();
                                break;
                            case 1:
                                TransferCash(guyData);
                                break;
                            case 2:
                                PrintAllGuysInfo(guyData);
                                break;
                            case 3:
                                Environment.Exit(0);
                                break;
                        }
                        break;
                }
                Console.Clear();
            } while (true);
        }

        public static void TransferCash(GuyData guyData)
        {
            Console.Clear();
            if (guyData.listOfGuys.Count < 2)
            {
                Console.WriteLine("There is nobody to transfer cash to.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Who is giving?");

            foreach (var guy in guyData.listOfGuys)
            {
                Console.WriteLine(guy.Name);
            }

            string giver = Console.ReadLine();

            Console.WriteLine("How much are you going to give?");
            int amount = int.Parse(Console.ReadLine());

            

            Console.WriteLine("Who is receiving?");
            string receiver = Console.ReadLine();

            Bank.TransferCash(guyData.listOfGuys[guyData.listOfGuys.FindIndex(guy => guy.Name == giver)], guyData.listOfGuys[guyData.listOfGuys.FindIndex(guy => guy.Name == receiver)], amount);
        }

        public static void PrintAllGuysInfo(GuyData guyData)
        {
            Console.Clear();
            foreach (Guy guy in guyData.listOfGuys)
            {
                guy.WriteMyInfo();
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
