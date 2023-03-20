namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Clown clown = new("Boffo", 14);
            Clown clown1 = new("Biff", height: 16);

            float f1 = 185.26F;
            double d2 = .0000316D;
            decimal m3 = 37.26M;

            int i1 = (int)f1;
            int i2 = (int)d2;
            int i3 = (int)m3;

            Console.WriteLine($"f1 = {f1}, i1 = {i1}");
            Console.WriteLine($"d2 = {d2}, i2 = {i2}");
            Console.WriteLine($"m3 = {m3}, i3 = {i3}");

            Console.WriteLine("Float");
            for (float f = 10; !float.IsInfinity(f); f *= f)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine("Double");
            for (double d = 10; !double.IsInfinity(d); d *= d)
            {
                Console.WriteLine(d);
            }

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
            Random random = new();
            if (Height > random.Next(20,25)) 
            {
                Height = random.Next(10, 15);
            }
        }
    }
}