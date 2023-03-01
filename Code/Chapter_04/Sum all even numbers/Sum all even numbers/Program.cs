namespace Sum_all_even_numbers
{
    public class Program
    {
        static void Main()
        { 
            Console.Write("Enter a number");
            int number = int.Parse(Console.ReadLine());
            int sum = SumOfEvenNumbers(number);
            Console.WriteLine($"The sum of all even numbers from 0 to {number} is {sum}");
        }

        public static int SumOfEvenNumbers(int number)
        {
           
            int sum = 0;
            for (int i = 2; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            
            return sum;
        }
    }
}