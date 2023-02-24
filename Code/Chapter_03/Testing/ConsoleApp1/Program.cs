namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Clown clown = new Clown("Boffo", 14);
            clown.TalkAboutYourself();
            Clown clown1 = new Clown("Biff", 16);
            clown1.TalkAboutYourself();
        }
    }

    public class Clown
    {
        private string Name { get; set; }
        private int Height { get; set; }

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