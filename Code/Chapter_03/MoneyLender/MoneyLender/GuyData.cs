namespace MoneyLender
{
    public class GuyData
    {
        public List<Guy> listOfGuys = new();

        public GuyData() {}

        //add new guy
        public void AddGuy()
        {
            Console.Clear();
            Console.Write("Enter name of new guy: ");
            string name = Console.ReadLine();
            Console.Write("Enter amount of cash: ");
            int amount = int.Parse(Console.ReadLine());
            listOfGuys.Add(new Guy(name, amount));
        }    
    }
}
