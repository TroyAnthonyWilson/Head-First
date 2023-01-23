using static System.Console;

namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            TryAnIf();
            TrySomeLoops();
            TryAnIfElse();
        }

        private static void TryAnIfElse()
        {
            int x = 5;
            int y = 10;
            if (x == y)
            {
                WriteLine($"x is {y}");
            }
            else
            {
                WriteLine($"x is not {y}");
            }
        }

        private static void TrySomeLoops()
        {
            int count = 0;
            while (count < 10)
            {
                count++;
            }
            for (int i = 0; i < 5; i++)
            {
                count--;
            }
            WriteLine($"The answer is {count}");
        }

        private static void TryAnIf()
        {
            int someValue = 4;
            string name = "Bob";
            if (someValue == 3 && name == "Joe")
            {
                WriteLine("x is 3 and the name is Joe");
            }
            WriteLine("This line runs");
        }
    }
}