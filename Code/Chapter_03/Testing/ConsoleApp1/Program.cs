namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Clown clown = new("Boffo", 14);
            Clown clown1 = new("Biff", height: 16);

            do
            {
                Console.Clear();
                clown.TalkAboutYourself();
                clown1.TalkAboutYourself();
                Console.WriteLine("Would you like to here about them again? (Y)");
            } while (Console.ReadLine().ToLower() == "y");
        }
    }

    public class Clown
    {
        /// <summary>
        /// The name of the clown
        /// </summary>
        private readonly string Name;
        private int Height;

        public Clown(string name, int height)
        {
            Name = name;
            Height = height;
        }

        /// <summary>
        /// write out the name and height of the clown and add 1 to the height
        /// </summary>
        public void TalkAboutYourself()
        {
            Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");
            Height++;
        }
    }
}