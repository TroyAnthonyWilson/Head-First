namespace Reference
{
    public class Elephant
    {
        private string Name { get; set; }
        private int EarSize { get; set; }

        public Elephant(string name, int earSize)
        {
            Name = name;
            EarSize = earSize;            
        }

        public void WhoAmI()
        {
            Console.WriteLine($"My name is {Name} and my ears are {EarSize} inches tall.");
        }
    }
}
