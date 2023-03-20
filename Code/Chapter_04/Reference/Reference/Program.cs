namespace Reference
{
    internal class Program
    {
        static void Main()
        {
            Elephant Lucinda = new Elephant("Lucinda", 33);
            Elephant Lloud = new Elephant("Lloyd", 40);

            do
            {
                Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap.");
                string input = Console.ReadLine();
                bool isNumber = int.TryParse(input, out int number);
                if (isNumber)
                {
                    switch (number)
                    {
                        case 1:
                            Lloud.WhoAmI();
                            break;
                        case 2:
                            Lucinda.WhoAmI();
                            break;
                        case 3:
                            (Lloud, Lucinda) = (Lucinda, Lloud);
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
            } while (true);
        }
    }
}