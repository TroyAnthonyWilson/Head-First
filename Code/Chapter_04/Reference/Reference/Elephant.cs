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

        public void ChangeEarSize(int earSize = -1)
        {
            Console.WriteLine(earSize);
            if (earSize > 0 && earSize <= 20)
            {
                EarSize = earSize;
                return;
            }
            Random random = new();
            EarSize = random.Next(5, 20);
        }

        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine($"{Name} heard a message.");
            Console.WriteLine($"{whoSaidIt.Name} said this: {message}");
        }

        public void SpeakTo(Elephant whoTalkTo, string message)
        {
            whoTalkTo.HearMessage(message, this);
        }
    }
}
