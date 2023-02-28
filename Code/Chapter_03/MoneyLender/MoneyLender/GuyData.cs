namespace MoneyLender
{
    public class GuyData
    {
        public List<Guy> listOfGuys = new List<Guy>();

        public GuyData() {}

        //add new guy
        public void AddGuy()
        {
            Console.WriteLine("Enter name of new guy:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter amount of cash:");
            int amount = int.Parse(Console.ReadLine());
            listOfGuys.Add(new Guy(name, amount));
        }
       
    }
}
