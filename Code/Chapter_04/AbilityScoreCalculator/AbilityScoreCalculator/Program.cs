namespace AbilityScoreCalculator
{
    public class Program
    {
        static void Main()
        {
            List<int> avrageScore = new();
            int MaxRoll = 0;

            for (int j = 0; j < 5; j++)
            {
                for (int i = 1; i < 8000; i++)
                {
                    int score = new AbilityScoreCalculator().CalculateAbilityScore();
                    if (score == 19) MaxRoll++;
                    avrageScore.Add(score);
                }
                Console.WriteLine(avrageScore.Average());
                Console.WriteLine(avrageScore.Max());
                Console.WriteLine(avrageScore.Min());
                avrageScore.Clear();
            }
            Console.WriteLine($"Maxed rolled {MaxRoll} times");
        }
    }

    public class AbilityScoreCalculator
    {
        public int RollResult = 0;
        public double DevideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;

        public int CalculateAbilityScore()
        {
            Random random = new();
            for (int i = 0; i <= 4; i++)
            {
                RollResult += (int)random.Next(1, 7);
            }
            double devided = (RollResult / DevideBy);
            Score = (int)devided + AddAmount;

            if (Score < Minimum)
            {
                Console.WriteLine("Min");
                Score = Minimum;
            }
            return Score;
        }
    }

}