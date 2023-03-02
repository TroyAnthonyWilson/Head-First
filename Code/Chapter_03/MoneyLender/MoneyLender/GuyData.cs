namespace MoneyLender
{
    public class GuyData
    {
        public List<Guy> listOfGuys = new();
        public GuyData()
        {
            //add some guys to the list
            //listOfGuys.Add(new Guy("John", 100));
            //listOfGuys.Add(new Guy("Mary", 200));
            //listOfGuys.Add(new Guy("Peter", 300));
        }

        //add new guy
        public void AddGuy()
        {
            Console.Clear();

            using(var context = new GuyContext())
            { 
                Console.Write("Enter name of new guy: ");
                string name = Console.ReadLine();

                Console.Write("Enter amount of cash: ");
                int amount = int.Parse(Console.ReadLine());

                context.Guys.Add(new Guy(name, amount));
                context.SaveChanges();
            }

           
            //listOfGuys.Add(new Guy(name, amount));
        }
    }
}
