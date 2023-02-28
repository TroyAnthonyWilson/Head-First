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
            int choice = 0;

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
                                PrintAllGuysInfo();
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
                Console.WriteLine("There is nobody else to transfer cash to.");
                Console.Write("Press any key to continue.");
                Console.ReadKey();
                return;
            }

            int giver = SelectGuy("Who is giving? ");

            Console.Clear();
            Console.WriteLine($"How much of {guyData.listOfGuys[giver].GetCashAmount()} is {guyData.listOfGuys[giver].Name} going to give?");
            int amount = int.Parse(Console.ReadLine());
            Console.Clear();

            int receiver = SelectGuy($"Who is receiving {amount}? ", giver);

            Bank.TransferCash(guyData.listOfGuys[giver], guyData.listOfGuys[receiver], amount);

            PrintAllGuysInfo();
        }
                                            
        public static void PrintAllGuysInfo()
        {
            Console.Clear();
            foreach (Guy guy in guyData.listOfGuys)
            {
                guy.WriteMyInfo();
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        //select guy
        public static int SelectGuy(string question, int giver = -1)
        {
            int choice = 0;
            bool down = false;

            do
            {
                if (giver == 0) choice = 1;
                else if (giver == guyData.listOfGuys.Count) choice = guyData.listOfGuys.Count -1;
                else if (giver == choice)
                {
                    if (down)
                    {
                        choice++;
                    }
                    else choice--;
                }

                Console.WriteLine(question);
                for (int i = 0; i < guyData.listOfGuys.Count; i++)
                {
                    if (i != giver)
                    {
                        if (choice == i)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine(guyData.listOfGuys[i].Name);
                        Console.ResetColor(); 
                    }
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (choice > 0)
                        {
                            choice--;
                            down = false;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (choice < guyData.listOfGuys.Count - 1)
                        {
                            choice++;
                            down = true;
                        }
                        break;
                    case ConsoleKey.Enter:
                        return choice;
                }
                Console.Clear();
            } while (true);         
        }
    }
}
