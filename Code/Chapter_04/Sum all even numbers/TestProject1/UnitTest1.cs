namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, 6)]
        [InlineData(10, 30)]
        [InlineData(1, 0)]
        [InlineData(0, 0)]

        public void TestMethod(int number, int expected)
        {
            // Arrange

            // Act
            int sum = Sum_all_even_numbers.Program.SumOfEvenNumbers(number);

            // Assert
            Assert.Equal(expected, sum);
        }
    }
}