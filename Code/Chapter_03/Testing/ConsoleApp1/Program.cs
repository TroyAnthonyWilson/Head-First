namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Clown clown = new("Boffo", 14);
            clown.TalkAboutYourself();
            Clown clown1 = new("Biff", 16);
            clown1.TalkAboutYourself();
        }
    }

    public class Clown
    {
        private readonly string Name;
        private readonly int Height;

        public Clown(string name, int height)
        {
            Name = name;
            Height = height;
        }

        public void TalkAboutYourself()
        {
            Console.WriteLine($"My name is {Name} nad I'm {Height} inches tall.");
        }
    }
}