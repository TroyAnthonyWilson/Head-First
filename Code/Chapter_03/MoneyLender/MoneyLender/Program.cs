namespace MoneyLender
{
    public class Program
    {
        static void Main()
        {
            //list of guys
            List<Guy> listOfGuys = new List<Guy>();
            listOfGuys.Add(new Guy("Bob", 100));
            listOfGuys.Add(new Guy("Joe", 50));

            PrintAllGuysInfo(listOfGuys);

            string giver = "Bob";
            string receiver = "Joe";

            Bank.TransferCash(listOfGuys[listOfGuys.FindIndex(guy => guy.Name == giver)], listOfGuys[listOfGuys.FindIndex(guy => guy.Name == receiver)], 10);

            PrintAllGuysInfo(listOfGuys);
        }

        //print all guys info
        static void PrintAllGuysInfo(List<Guy> listOfGuys)
        {
            foreach (Guy guy in listOfGuys)
            {
                guy.WriteMyInfo();
            }
        }
    }
}